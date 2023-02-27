using DevstreamTestTask.Design.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevstreamTestTask.Reflection
{
    public static class InstanceService
    {
        public static IEnumerable<T> GetInstances<T>()
        {
            //Needed parameterless constructor to initiate creation of every subclass instance
            IEnumerable<T> instances = typeof(T).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(T)) 
            && !t.IsAbstract
            ).Select(t => (T)Activator.CreateInstance(t));
            return instances;
        }

        public static IEnumerable<T> SearchForInstances<T>(string partialName)
        {
            return GetInstances<T>().Where(w => w.GetType().Name.Contains(partialName));
        }

        public static void WriteInstancesToDisc(string path = "default.txt")
        {
            using (StreamWriter writetext = new StreamWriter(path))
            {
                foreach (var item in GetInstances<Vehicle>().OrderBy(o => o.GetType().Name))
                {
                    writetext.WriteLine($"{item.GetType().Name}");
                }
            }
        }
    }
}
