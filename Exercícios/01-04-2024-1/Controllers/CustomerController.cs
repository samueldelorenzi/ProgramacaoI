using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_04_2024_1.Models;
using _01_04_2024_1.Repository;
using _01_04_2024_1.Utils;

namespace _01_04_2024_1.Controllers
{
    public class CustomerController
    {
        private CustomerRepository customerRepository;
        public CustomerController()
        {
            customerRepository = new CustomerRepository();
        }
        public void Insert(Customer customer)
        {
            customerRepository.Save(customer);
        }
        public Customer GetCustomerById(int id)
        {
            return customerRepository.Retrieve(id);
        }
        public List<Customer> Get()
        {
            return customerRepository.Retrieve();
        }
        public List<Customer> GetByName(string nome)
        {
            return customerRepository.RetrieveByName(nome);
        }
        public bool ExportToDelimited()
        {
            List<Customer> list = customerRepository.Retrieve();

            string fileContent = string.Empty;
            foreach (var c in list)
            {
                fileContent += $"{c.PrintToExportDelimited()}\n";
            }

            string fileName = $"Delimited-Customer_{DateTimeOffset.Now.ToUnixTimeSeconds()}.txt";
            return ExportToFile.SaveToDelimitedTxt(fileName, fileContent);

        }
        public bool ExportToComposed()
        {
            List<Customer> list = customerRepository.Retrieve();

            string fileContent = string.Empty;
            foreach (var c in list)
            {
                fileContent += $"{c.PrintToExportComposed()}\n";
            }

            string fileName = $"Composed-Customer_{DateTimeOffset.Now.ToUnixTimeSeconds()}.txt";
            return ExportToFile.SaveToDelimitedTxt(fileName, fileContent);

        }
        public string ImportFromDelimited(string filePath, string delimiter)
        {
            bool result = true;
            string msgReturn = string.Empty;
            int lineCountSuccess = 0;
            int lineCountError = 0;
            int lineCountTotal = 0;

            try
            {
                if (!File.Exists(filePath))
                    return "ERRO: Arquivo de importação não encontrado";

                using(StreamReader sr = new StreamReader(filePath))
                {
                    string line = string.Empty;
                    while((line = sr.ReadLine()) != null)
                    {
                        lineCountTotal++;
                        if(!customerRepository.ImportFromTxt(line, delimiter))
                        {
                            result = false;
                            lineCountError++;
                        }
                        else
                            lineCountSuccess++;
                    }
                }
            }
            catch(System.Exception ex)
            {
                return $"ERRO: {ex.Message}";
            }
            if (result)
                msgReturn = "Dados importados com sucesso";
            else
                msgReturn = $"Dados parcialmente importados";

            msgReturn += $"\nTotal de linhas: {lineCountTotal}\nLinhas importadas com sucesso: {lineCountSuccess}\nLinhas com erro: {lineCountError}";

            return msgReturn;
        }

    }
}
