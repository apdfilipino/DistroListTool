
# DistroListTool

**DistroListTool** is a Microsoft Outlook add-in that enables users to quickly create new email drafts using predefined recipient lists. This tool is ideal for individuals or teams that frequently send emails to the same set of people, reducing manual entry and minimizing errors.

## 📌 Features

- 📋 Load distribution lists from a configurable JSON file.
- 📧 Automatically populate **To**, **CC**, and **BCC** fields in a new email.
- 🖱️ Simple and user-friendly interface integrated into the Outlook ribbon.
- ⚙️ Easily maintain and update distribution groups via a single JSON file.

## 🗂️ Distribution List Format

The add-in reads from a JSON file formatted as follows:

```json
{
  "version": "v1.0.0",
  "distroList": [
    {
      "name": "Distro List Name",
      "distros": [
        {
          "name": "HTML Template 1",
          "to": [
            "to@email.com",
            "to.2@email.com"
          ],
          "cc": [
            "cc@email.com"
          ],
          "bcc": [
            "bcc@email.com"
          ],
          "subject": "Sample HTML Template",
          "body": "<html><body><h1>Sample</h1><h3>HTML Template</h3></body></html>",
          "htmlFormat": true
        }
      ]
    }
  ]
}
```

Each entry in the `distroList` array can contain:
- `name`: A label for the distribution list.
- `distros`: An array of distribution list metadata.
  - Each entry in the `distros` array can contain:
  - `to`, `cc`, `bcc`: Arrays of email addresses for each recipient group.
  - `subject`: The subject of the email.
  - `body`: The body of the email.
  - `htmlFormat`: Determines if the `body` should be rendered as HTML.

Example JSON: [sample.distro.config.json](https://raw.githubusercontent.com/apdfilipino/DistroListTool/refs/heads/master/Samples/sample.distro.config.json)

## 🧭 Usage

### 🛠️ Setup Instructions

1. Open Outlook with the DistroListTool add-in installed.
2. Click the **Configure DL Tool** button in the Outlook ribbon.
3. Input the full path of your configuration file into the textbox.
- Tick **Local File** if the file is found locally.
4. Click **Configure** to load and apply the distribution lists.


1. In the ribbon, click on the **Open DL Tool** button.
3. Select a distribution list from the dropdown.
4. A new email draft will open, pre-filled with recipients as configured in the JSON.

## 📄 License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

---

Created by [apdfilipino](https://github.com/apdfilipino)
