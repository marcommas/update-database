using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;


namespace AtualizacaoBaseDeDados
{
    class ConFirebird
    {

        public void ArrumarConexao(String iP, String caminho)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("AtualizacaoBaseDeDados.exe.config");

            file.WriteLine("<?xml version=\"1.0\"?>");
            file.WriteLine("<configuration>");
            file.WriteLine("  <connectionStrings>");
            file.WriteLine("    <add name=\"FireBirdConnectionString\" connectionString=\"server=" + iP + ";database=" + caminho + ";User=SYSDBA;Password=masterkey\"/>");
            file.WriteLine("  </connectionStrings>");
            file.WriteLine("  <appSettings>");
            file.WriteLine("    <add key=\"Parametro\" value=\"\"/>");
            file.WriteLine("    <add key=\"Setting1\" value=\"Very\"/>");
            file.WriteLine("    <add key=\"Setting2\" value=\"Easy\"/>");
            file.WriteLine("    <add key=\"ClientSettingsProvider.ServiceUri\" value=\"\"/>");
            file.WriteLine("  </appSettings>");
            file.WriteLine("  <startup>");
            file.WriteLine("    <supportedRuntime version=\"v4.0\" sku=\".NETFramework,Version=v4.0,Profile=Client\"/>");
            file.WriteLine("  </startup>");
            file.WriteLine("  <system.web>");
            file.WriteLine("    <membership defaultProvider=\"ClientAuthenticationMembershipProvider\">");
            file.WriteLine("      <providers>");
            file.WriteLine("        <add name=\"ClientAuthenticationMembershipProvider\" type=\"System.Web.ClientServices.Providers.ClientFormsAuthenticationMembershipProvider, System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\" serviceUri=\"\"/>");
            file.WriteLine("      </providers>");
            file.WriteLine("    </membership>");
            file.WriteLine("    <roleManager defaultProvider=\"ClientRoleProvider\" enabled=\"true\">");
            file.WriteLine("      <providers>");
            file.WriteLine("        <add name=\"ClientRoleProvider\" type=\"System.Web.ClientServices.Providers.ClientRoleProvider, System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\" serviceUri=\"\" cacheTimeout=\"86400\"/>");
            file.WriteLine("      </providers>");
            file.WriteLine("    </roleManager>");
            file.WriteLine("  </system.web>");

            file.WriteLine("</configuration>");

            file.Flush();

            file.Close();
        }
    }
}
