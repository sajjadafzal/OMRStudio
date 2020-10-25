using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace OMRStudio
{
    public static class Factory
    {
        public static T CreateNew<T>() where T : class, new()
        {
            T instance = new T();
            return instance;
        }
    }
}
