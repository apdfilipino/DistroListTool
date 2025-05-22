using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DistroListTool.Interfaces;
using DistroListTool.Models;
using DistroListTool.Utils;
using Microsoft.Office.Interop.Outlook;

namespace DistroListTool
{
    public class DistroListService
    {
        private Application _application;
        private DistroConfig _distroConfig;
        public Config Config = null;
        
        private string MainConfigPath => $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\DistroToolVSTO\config.json";

        public DistroListService()
        {
            TryReadConfig();
            if (Config != null)
            {
                GetDistroLists();
            }
        }

        public void OpenForm()
        {
            if (Config == null)
            {
                System.Windows.Forms.MessageBox.Show("DL Tool not configured. Please check", "DL Tool");
                return;
            }
            var form = new DistroListForm(_distroConfig)
            {
                StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            };
            form.ShowDialog();
            var template = form.SelectedTemplate;
            if (template != null)
            {
                CreateMailItem(template);
            }
        }

        public void OpenConfigureForm()
        {
            var form = new ConfigureForm(this)
            {
                StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            };
            form.ShowDialog();
        }

        public string GetVersion()
        {
            return _distroConfig.Version;
        }

        public async Task<DistroConfig> PersistIfExists(Config config)
        {
            IDistroRepo repo;
            if (config.IsLocal)
            {
                repo = new LocalDistroUtil();
            }
            else
            {
                repo = new OnlineDistroUtil();
            }

            try
            {
                _distroConfig = await repo.GetDistroListsAsync(config.Path).ConfigureAwait(false);

                var localConfig = new LocalConfigUtil();
                var filePath = MainConfigPath;
                localConfig.PersistConfig(filePath, config);
                Config = config;

                return _distroConfig;
            }
            catch
            {
                return null;
            }
        }

        public void CreateMailItem(DistroListItem distro)
        {
            CreateMailItem(
                subject: distro.Subject,
                to: distro.ToRecepients,
                body: distro.Body,
                cc: distro.CcRecepients,
                bcc: distro.BccRecepients,
                format: distro.HtmlFormat ? OlBodyFormat.olFormatHTML : OlBodyFormat.olFormatPlain
                );
        }

        public void GetDistroLists()    
        {
            IDistroRepo repo;
            if (Config.IsLocal) { repo = new LocalDistroUtil(); }
            else { repo = new OnlineDistroUtil(); }

            var task = repo.GetDistroListsAsync(Config.Path);
            task.Wait();
            _distroConfig = task.Result;
        }

        public void CreateMailItem(
            string subject,
            string to,
            string body,
            string cc,
            string bcc,
            OlBodyFormat format = OlBodyFormat.olFormatHTML
            )
        {
            if (_application == null) return;
            MailItem mailItem = (MailItem)_application.CreateItem(OlItemType.olMailItem);
            mailItem.BodyFormat = format;
            mailItem.Subject = subject;
            mailItem.To = to;
            mailItem.CC = cc;
            mailItem.BCC = bcc;

            if (format == OlBodyFormat.olFormatHTML)
            {
                mailItem.HTMLBody = body;
            }
            else
            {
                mailItem.Body = body;
            }
            mailItem.Display(true);
        }

        public DistroListService AddApplicationInstance(Application application)
        {
            _application = application;
            return this;
        }

        private void TryReadConfig() 
        {
            try
            {
                var localRepo = new LocalConfigUtil();
                var task = localRepo.GetConfig(MainConfigPath);
                task.Wait();
                var config = task.Result;
                Config = config;
            }
            catch
            { }
        }

    }
}
