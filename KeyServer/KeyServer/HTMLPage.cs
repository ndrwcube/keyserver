using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyServer
{
    class HTMLPage
    {
        static string GenerateFromTemplate(string body, string title)
        {
            return 
@"<!DOCTYPE html>
<html lang=""en"">
    <head>
        <meta charset=""UTF-8"">
        <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
        <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
        <title>"+title+@"</title>
    </head>
    "+body+@"
</html>";
        }

        public static string StatsPage()
        {
            return GenerateFromTemplate(@"<body style=""font-family: sans-serif;""><h1 style=""font-weight: normal;"">KeyServer Statistics</h1><style type=""text/css"">
.tg  {border-collapse:collapse;border-spacing:0;}
.tg td{border-color:black;border-style:solid;border-width:1px;font-family:Arial, sans-serif;font-size:14px;
  overflow:hidden;padding:10px 5px;word-break:normal;}
.tg th{border-color:black;border-style:solid;border-width:1px;font-family:Arial, sans-serif;font-size:14px;
  font-weight:normal;overflow:hidden;padding:10px 5px;word-break:normal;}
.tg .tg-0lax{text-align:left;vertical-align:top}
.tg .tg-0pky{border-color:inherit;text-align:left;vertical-align:top}
</style>
<table class=""tg""><thead>
  <tr>
    <th class=""tg-0lax"">Item</th>
    <th class=""tg-0lax"">Description</th>
  </tr></thead>
<tbody>
  <tr>
    <td class=""tg-0pky"">Server start time</td>
    <td class=""tg-0pky"">"+Program.starttime+@"</td>
  </tr>
  <tr>
    <td class=""tg-0pky"">Timezone</td>
    <td class=""tg-0pky"">"+TimeZoneInfo.Local.StandardName+ @"</td>
  </tr>
  <tr>
    <td class=""tg-0pky"">KeyServer version</td>
    <td class=""tg-0pky""></td>
  </tr>
  <tr>
    <td class=""tg-0pky""></td>
    <td class=""tg-0pky""></td>
  </tr>
  <tr>
    <td class=""tg-0pky"">Server admin contact</td>
    <td class=""tg-0pky""></td>
  </tr>
  <tr>
    <td class=""tg-0pky"">Description</td>
    <td class=""tg-0pky""></td>
  </tr>
</tbody>
</table><br><p>Made with &#10084;&#65039;</p><p>© 2024 Andrew (github.com/@ndrwcube)</p></body>", "KeyServer Statistics");
        }

        public static string PageNotFound = 
@"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>KeyServer | 404</title>
    <style>
        body {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
            font-family: sans-serif;
            background-color: #f4f4f4;
            color: #333;
            text-align: center;
        }
        h1 {
            font-weight: normal;
            font-size: 4em;
            margin: 0;
            color: #e74c3c;
        }
        p {
            font-size: 1.2em;
            margin: 20px 0;
        }
        a {
            text-decoration: none;
            color: #3498db;
            font-weight: bold;
        }
        a:hover {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <div>
        <h1>404</h1>
        <p>Oops! The page you're looking for doesn't exist.</p>
        <p><a href=""/"">Go back to the KeyServer Homepage</a></p>
    </div>
</body>
</html>";

        public static string publicroot = GenerateFromTemplate(
@"<body style=""font-family: sans-serif;"">
    <div><h1 style=""font-weight: normal; display: inline; vertical-align: bottom;"">KeyServer</h1><p style=""display: inline; vertical-align: bottom;"">Profiles | Account Center</p></div>
    <div style=""height: 1px; background-color: black;""></div>
    <p>KeyServer is up and running!</p>
    <p>Made with &#10084;&#65039;</p><p>© 2024 Andrew (github.com/@ndrwcube)</p>
</body>",
        "KeyServer");
    }
}
