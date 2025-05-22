using System;
using Microsoft.Office.Core;

namespace DistroListTool
{
    public partial class ThisAddIn
    {
        private DistroListService _service;
        private DistroListRibbon _ribbon;

        private void ThisAddIn_Startup(object sender, EventArgs e)
        {
            _service.AddApplicationInstance(Application);
        }

        protected override IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            return GetRibbon();
        }

        private DistroListRibbon GetRibbon()
        {
            if (_ribbon == null)
            {
                _ribbon = new DistroListRibbon(GetDistroListService());
            }
            return _ribbon;
        }

        private DistroListService GetDistroListService()
        {
            if (_service == null)
            {
                _service = new DistroListService();
            }
            return _service;
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new EventHandler(ThisAddIn_Startup);
        }
        
        #endregion
    }
}
