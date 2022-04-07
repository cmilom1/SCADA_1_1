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

        public static async Task<int[]> Start(int[] datosEnterosWrite)
        {
            int counterFail = 0;
            ModbusClient PLC = new ModbusClient(Program.PLCip, 502);
            //int[] datosEnterosRead = new int[101];
            //parametros a inicializar

            await Task.Run(() =>
            {
                //tarea a ejecutar

                try
                {
                    PLC.Connect();
                }
                catch
                {
                    counterFail = 100;
                    Program.readDataMB[0] = -999;//control comunicacion
                }

                if (counterFail == 0)
                {
                    Program.readDataMB = PLC.ReadHoldingRegisters(1499, 51);

                    PLC.WriteMultipleRegisters(1550, datosEnterosWrite); //escritura
                    PLC.Disconnect();


                }

            });


            return Program.readDataMB;

        }


    }

}
