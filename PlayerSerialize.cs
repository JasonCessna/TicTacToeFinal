using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class PlayerSerialize
    {
        public static void SerializePlayer(List<Player> p)
        {
            try
            {
                using (Stream stream = File.Open("players.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, p);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void DeserializePlayer(ref List<Player> p)
        {
            try
            {
                using (Stream stream = File.Open("players.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    p = (List<Player>)bin.Deserialize(stream);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
