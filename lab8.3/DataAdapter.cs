using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8._3
{
    public class DataAdapter : IDataAdapter
    {
        private IDataTemplate sourceTemplate;
        private IDataTemplate destinationTemplate;

        public DataAdapter(IDataTemplate sourceTemplate, IDataTemplate destinationTemplate)
        {
            this.sourceTemplate = sourceTemplate;
            this.destinationTemplate = destinationTemplate;
        }

        public void ConvertData(string sourcePath, string destinationPath)
        {
            sourceTemplate.ReadData(sourcePath);

            sourceTemplate.ConvertData(destinationTemplate);

            destinationTemplate.WriteData(destinationPath);
        }
    }
}
