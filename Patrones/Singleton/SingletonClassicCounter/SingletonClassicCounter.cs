using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonClassicCounter
{
    // esta es la clase de la que queremos tener una unica instancia
    public class GlobalCounter
    {
        // aca vamos a guardar la unica instancia 
        // de esta clase. Notar que es un atributo de clase
        private static GlobalCounter _instance;

        private int _counter;
        
        // Hacer el constructor privado: me asegura que nadie mas puede crear instancias
        private GlobalCounter() {
            // ....
            _instance = null;
        }

        public static GlobalCounter Instance {
            get
            {
                if (_instance == null)
                {
                    _instance = new GlobalCounter();
                }
                return _instance;
            }
        }

        // ....
        // logica propia de sistema. En este ejemplo, solo llevar un contador
        
        public void Increment() {
            this._counter++;
        }

        public int Counter() {
            return this._counter;
        }
    }
}
