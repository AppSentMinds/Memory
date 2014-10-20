using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Memory
{
    public class Images
    {
        public static Image[] DeckAnimals()
        {
            Image[] d1 = new Image[]
{

Properties.Resources.D1_01_Dog,
Properties.Resources.D1_02_Blackbird,
Properties.Resources.D1_03_BluetitLook,
Properties.Resources.D1_04_BluetitEgg,
Properties.Resources.D1_05_Dragonfly,
Properties.Resources.D1_06_Seagull,
Properties.Resources.D1_07_HorseHead,
Properties.Resources.D1_08_Sparrow,
Properties.Resources.D1_09_Cranes,
Properties.Resources.D1_10_CanadianGooseWings,
Properties.Resources.D1_11_Squirrel,
Properties.Resources.D1_12_SwanButts,
Properties.Resources.D1_13_Bumblebee,
Properties.Resources.D1_14_EuropeanAdder,
Properties.Resources.D1_15_Redrobin,
Properties.Resources.D1_16_Sheep,
Properties.Resources.D1_17_Bullfinch,
Properties.Resources.D1_18_CowCalf,
Properties.Resources.D1_19_Lapwing,
Properties.Resources.D1_20_Nuthatcher,
Properties.Resources.D1_21_Cows,
Properties.Resources.D1_22_SharPei,
Properties.Resources.D1_23_GreatTit,
Properties.Resources.D1_24_SwanHead,
Properties.Resources.D1_25_Eagle,
Properties.Resources.D1_26_CrestedTit,
Properties.Resources.D1_27_Jackdaw,
Properties.Resources.D1_28_CrestedGrebe,
Properties.Resources.D1_29_FlyingGoose,
Properties.Resources.D1_30_Waxwing,
Properties.Resources.D1_31_Frog,
Properties.Resources.D1_32_SmallDog,
Properties.Resources.BackcardGreen
};

            return d1;
        }

        public static Image[] DeckOther()
        {
            Image[] d2 = new Image[]
{
Properties.Resources.D2_01_FlyAgaric,
Properties.Resources.D2_02_Clouds,
Properties.Resources.D2_03_Moon,
Properties.Resources.D2_04_Camera,
Properties.Resources.D2_05_Apple,
Properties.Resources.D2_06_ColorfulLeaf,
Properties.Resources.D2_07_Coffee,
Properties.Resources.D2_08_GreenLeafs,
Properties.Resources.D2_09_Oak,
Properties.Resources.D2_10_Chimney,
Properties.Resources.D2_11_Woodenwall,
Properties.Resources.D2_12_Railway,
Properties.Resources.D2_13_Elderflowers,
Properties.Resources.D2_14_Stones,
Properties.Resources.D2_15_Sunflower,
Properties.Resources.D2_16_Runners,
Properties.Resources.D2_17_Flower,
Properties.Resources.D2_18_RedHouse,
Properties.Resources.D2_19_Pipes,
Properties.Resources.D2_20_Plane,
Properties.Resources.D2_21_MTB,
Properties.Resources.D2_22_Swimmer,
Properties.Resources.D2_23_Can,
Properties.Resources.D2_24_Flowerpot,
Properties.Resources.D2_25_PostalBoat,
Properties.Resources.D2_26_RailwaySign,
Properties.Resources.D2_27_Toadstool,
Properties.Resources.D2_28_RedCottage,
Properties.Resources.D2_29_Entrance,
Properties.Resources.D2_30_Door,
Properties.Resources.D2_31_Lightbulb,
Properties.Resources.D2_32_CherryBlossom,
Properties.Resources.BackcardRed
};

            return d2;

        }

        public static Image[] Timer()
        {
            Image[] timer = new Image[]
{
Properties.Resources.TimerNew01,
Properties.Resources.TimerNew02,
Properties.Resources.TimerNew03,
Properties.Resources.TimerNew04,
Properties.Resources.TimerNew05,
Properties.Resources.TimerNew06,
Properties.Resources.TimerNew07,
Properties.Resources.TimerNew08,
Properties.Resources.TimerNew09,
Properties.Resources.TimerNew10,
Properties.Resources.TimerNew11
};
            return timer;
        }
    }
}