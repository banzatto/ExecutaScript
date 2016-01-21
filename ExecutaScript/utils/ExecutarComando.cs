using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ExecutaScript.utils
{
    public class ExecutarComando
    {


        public static RetornoComando ExecutaComando(String comando, String parametros)
        {
            RetornoComando ret = new RetornoComando();
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo(comando, parametros);
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
                psi.WindowStyle = ProcessWindowStyle.Hidden;

                Process p = Process.Start(psi);
                p.WaitForExit();
                ret.Codigo = p.ExitCode;
                ret.Mensagem = "OK";
            }
            catch (Win32Exception e)
            {
                ret.Codigo = e.NativeErrorCode ;
                ret.Mensagem = e.Message;
            }

            catch (Exception e)
            {
                ret.Codigo = -1;
                ret.Mensagem = e.Message;
            }

            return ret;
        }

        public static RetornoComando DownloadFile(String origem,String destino)
        {
            RetornoComando ret = new RetornoComando();
            
            using (var client = new WebClient())
            {
                try {
                    client.DownloadFile(origem, destino);
                }
                catch (WebException e)
                {
                    ret.Codigo = -1;
                    ret.Mensagem = e.Message;
                }
                catch (Exception e)
                {
                    ret.Codigo = -1;
                    ret.Mensagem = e.Message;
                }
            }
            return ret;
            
        }

        public static RetornoComando ParseComando(String comando)
        {
            RetornoComando ret = null;
            String[] partes = comando.Split(new String[] { "#" }, StringSplitOptions.None);
            
            if (partes[0].Equals("exec",StringComparison.InvariantCultureIgnoreCase))
            {
                string comm = "";
                string param = "";


                if (partes.Length > 2)
                {
                    comm = partes[1];
                    param = partes[2];
                } else if(partes.Length == 2)
                {
                    comm = partes[1];
                }
                ret = ExecutaComando(comm, param);
            }
            if (partes[0].Equals("download", StringComparison.InvariantCultureIgnoreCase))
            {
                String origem = "";
                String destino = "";
                if (partes.Length > 2)
                {
                    origem= partes[1];
                    destino = partes[2];
                }
                ret = DownloadFile(origem, destino);
            }

            if (ret == null)
            {
                ret = new RetornoComando() { Codigo = 0, Mensagem = "OK" };                
            }
            return ret;
        }


        


    }
}
