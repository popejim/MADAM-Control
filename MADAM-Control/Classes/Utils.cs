using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CsvHelper;

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
            try
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
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
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

        public static List<Companies> GetCompanies()
        {
            try
            {
                List<Companies> returnList;
                string savePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

                XmlSerializer mySerializer = new XmlSerializer(typeof(List<Companies>));
                StreamReader myReader = new StreamReader(savePath + "\\MADAMControl\\Companies.XML");

                returnList = (List<Companies>)mySerializer.Deserialize(myReader);
                myReader.Close();
                return returnList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public static void saveCompany(Companies coIn, List<Companies> listIn)
        {
            List<Companies> currentCompanies = listIn;
            if (currentCompanies.Any(c=>c.CompName == coIn.CompName))
            {
                currentCompanies.Clear();
                currentCompanies.Add(coIn);
                saveAllCompany(currentCompanies);
            }

            else
            {
                currentCompanies.Add(coIn);
                saveAllCompany(currentCompanies);
            }
        }

        public static void exportAllToCsv(List<Companies> inList)
        {
            string savePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            StreamWriter myWriter = new StreamWriter(savePath + "\\MADAMControl\\AllCompanies.csv");

            using (CsvWriter csv = new CsvWriter(myWriter, System.Globalization.CultureInfo.CurrentCulture))
            {
                csv.WriteRecords(inList);
            }

            
        }

        internal static void exportOneToCsv(Companies currCompany)
        {
            string savePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string compName = currCompany.CompName;
            StreamWriter myWriter = new StreamWriter(savePath + "\\MADAMControl\\"+ compName +".csv");

            using (CsvWriter csv = new CsvWriter(myWriter, System.Globalization.CultureInfo.CurrentCulture))
            {
                csv.WriteRecord<Companies>(currCompany);
                csv.WriteRecords(currCompany.DeviceList);
            }
        }
    }
}
