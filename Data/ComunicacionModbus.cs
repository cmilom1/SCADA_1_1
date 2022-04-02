using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyModbus;

namespace SCADA_1_1.Data
{
    public class ComunicacionModbus
    {
        public static async Task<int[]> Start()
        {
            //parametros a inicializar
            ModbusClient PLC = new ModbusClient("127.0.0.1", 502);
            PLC.Connect();
            //int[] datosEnteros = new int[10];
            await Task.Run(() =>
            {
                //tarea a ejecutar
                Program.readDataMB = PLC.ReadHoldingRegisters(1500, 50);
                PLC.Disconnect();

            });

            return Program.readDataMB;
        }
    }
}
