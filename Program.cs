using System;

namespace garys_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero ()
            {
                MainColor = "blue",
                MaximumOccupancy = 4,
            };

            Tesla modelS = new Tesla ()
            {
                MainColor = "gray",
                MaximumOccupancy = 3
            };
            Cessna mx410 = new Cessna ()
            {
                MainColor = "purple",
                MaximumOccupancy = 5
            };
            Ram bigBoi = new Ram ()
            {
                MainColor = "pink",
                MaximumOccupancy = 6
            };

            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();

            mx410.Drive();
            mx410.Turn("left");
            mx410.Stop();

            modelS.Drive();
            modelS.Turn("right");
            modelS.Stop();

            bigBoi.Drive();
            bigBoi.Turn("right");
            bigBoi.Stop();
            
        }
    }
}
