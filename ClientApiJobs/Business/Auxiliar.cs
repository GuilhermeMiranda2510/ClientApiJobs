using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ClientApiJobs.Business
{
  public  class Auxiliar
    {
        public void WriteLog(String usuario, String diretorio, String metodo, String erro)
        {
            string contents = "Date: " + DateTime.Now + Environment.NewLine +
               "Method: " + metodo + Environment.NewLine +
               "User: " + usuario + Environment.NewLine +
               //"Hostname: " + Data.MetaDataInfo.Hostname + Environment.NewLine +
               //"Version: " + Data.MetaDataInfo.VersionCompiled + Environment.NewLine +
               "Error: " + Environment.NewLine + erro + Environment.NewLine + Environment.NewLine;
            string path = CreateFileLog(diretorio);

            try
            {
                File.AppendAllText(path, contents);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            var teste = "";
        }

        public String CreateFileLog(String path)
        {
            String PathFinish = CreateDirectoryLog(path) + "\\log_" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + ".txt";

            if (!File.Exists(PathFinish))
            {
                try
                {
                    var myfile = File.Create(PathFinish);
                    myfile.Close();
                    return PathFinish;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return PathFinish;
            }
            return PathFinish;
        }

        public String CreateDirectoryLog(String path)
        {
            String PathFinish = Configuiration.WriteLog() + path;
            if (!Directory.Exists(PathFinish))
            {
                try
                {
                    Directory.CreateDirectory(PathFinish);
                    return PathFinish;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return PathFinish;
        }
    }
}
