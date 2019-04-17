namespace customsounds {
    public interface IElectricPowered {
        double BatteryKWh { get; set; }

        void ChargeBattery ();
    }
}