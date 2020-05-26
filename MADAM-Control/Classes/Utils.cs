using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MADAM_Control.Classes
{
    public class Utils
    {
        public static List<Device> returnList;
        public static string remoteIp;
        public static List<Device> getRemoteDevices(string ip)
        {
            TcpClient probeServer = new TcpClient();
            remoteIp = ip;
            probeServer.BeginConnect(ip, 42060,getDevice,probeServer);
            probeServer.Close();
            List<Device> temp = returnDevices();
            return temp;
        }

        public static void getDevice(IAsyncResult ar)
        {
            TcpClient listener = (TcpClient)ar.AsyncState;
            TcpClient client = new TcpClient(remoteIp, 42063);
            NetworkStream stream = client.GetStream();
            XmlSerializer mySerializer = new XmlSerializer(typeof(List<Device>));
            List<Device> inList = (List<Device>)mySerializer.Deserialize(stream);
            returnList = inList;
            stream.Close();
            client.Close();
        }

        public static List<Device> returnDevices()
        {
            return returnList;
        }
        public static void saveAllCompany(List<Companies> listIn)
        {
            string savePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            XmlSerializer mySerializer = new XmlSerializer(typeof(List<Companies>));
            if (Directory.Exists(savePath + "\\MADAMControl\\"))
            {
                StreamWriter myWriter = new StreamWriter(savePath + "\\MADAMControl\\Companies.XML");
                mySerializer.Serialize(myWriter, listIn);
                myWriter.Close();
            }

            else
            {
                Directory.CreateDirectory(savePath + "\\MADAMControl\\");
                StreamWriter myWriter = new StreamWriter(savePath + "\\MADAMControl\\Companies.XML");
                mySerializer.Serialize(myWriter, listIn);
                myWriter.Close();
            }
        }


        public static void saveCompany(Companies coIn)
        {
            string savePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            try
            {
                XmlSerializer mySerializer = new XmlSerializer(typeof(Companies));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            if (Directory.Exists(savePath + "\\MADAMControl\\"))
            {
                try
                {
                    XmlSerializer mySerializer = new XmlSerializer(typeof(Companies));
                    StreamWriter myWriter = new StreamWriter(savePath + "\\MADAMControl\\Companies.XML");
                    mySerializer.Serialize(myWriter, coIn);
                    myWriter.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }

            else
            {
                XmlSerializer mySerializer = new XmlSerializer(typeof(Companies));
                Directory.CreateDirectory(savePath + "\\MADAMControl\\");
                StreamWriter myWriter = new StreamWriter(savePath + "\\MADAMControl\\Companies.XML");
                mySerializer.Serialize(myWriter, coIn);
                myWriter.Close();
            }
        }
    }
}
