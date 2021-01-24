using System.Security.Cryptography;

namespace OpenXComEdit.Lib
{
    public class Ufo
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
        public int Id { get; set; }
        public Destination Dest { get; set; }
        public double SpeedLon { get; set; }
        public double SpeedLat { get; set; }
        public double SpeedRadian { get; set; }
        public int Speed { get; set; }
        public string Type { get; set; }
        public int LandId { get; set; }
        public int Damage { get; set; }
        public string Altitude { get; set; }
        public string Direction { get; set; }
        public int Status { get; set; }
        public bool Detected { get; set; }
        public int SecondsRemaining { get; set; }
        public int Mission { get; set; }
        public string Trajectory { get; set; }
        public int TrajectoryPoint { get; set; }
        public int FireCountdown { get; set; }
        public int EscapeCountdown { get; set; }

        public Ufo(double lat, double lon, int id, Destination dest, double speedLon, double speedLat, double speedRadian, int speed, string type, int landId, int damage, string altitude, string direction, int status, bool detected, int secondsRemaining, int mission, string trajectory, int trajectoryPoint, int fireCountdown, int escapeCountdown)
        {
            Lat = lat;
            Lon = lon;
            Id = id;
            Dest = dest;
            SpeedLon = speedLon;
            SpeedLat = speedLat;
            SpeedRadian = speedRadian;
            Speed = speed;
            Type = type;
            LandId = landId;
            Damage = damage;
            Altitude = altitude;
            Direction = direction;
            Status = status;
            Detected = detected;
            SecondsRemaining = secondsRemaining;
            Mission = mission;
            Trajectory = trajectory;
            TrajectoryPoint = trajectoryPoint;
            FireCountdown = fireCountdown;
            EscapeCountdown = escapeCountdown;
        }

        public Ufo()
        {
            
        }
    }
}