namespace ShippingPortGOF.Static
{
    public static class Constants
    {
        public static string UNICODE_ESC { get; } = "\u001b[";

        public static string[] MooringTypes { get; } = { "PU", "PO", "OS" };

        public static string[] ShipTypes { get; } = { "TR", "KA", "KL", "KR", "RI", "TE", "JA", "BR", "RO" };

        public static string[] PassengerShips { get; } = { "TR", "KA", "KL", "KR" };

        public static string[] BusinessShips { get; } = { "RI", "TE" };

        public static string[] OtherShips { get; } = { "JA", "BR", "RO" };

        private static string ArgumentR { get; } = @"(-r [a-zA-Z_0-9.]+\.csv)";

        private static string MandatoryArguments { get; } = @"(-(?:(?:(?:br) \d{2})|(?:(?:vt) "
        + @"(?:(?:50:50)|(?:25:75)|(?:75:25)){1})|(?:(?:pd) (?:(?:R:P)|(?:P:R)){1})|(?:(?:(?:mv)"
        + @"|[lvbmk]){1} [a-zA-Z_0-9.]+\.csv)){1})";

        public static string InputArguments { get; } = @"^(?:" + $"{ArgumentR}"
            + @"(?!.*\1) )?" + $"{MandatoryArguments}" + @"(?!.*\2)(?: " + $"{ArgumentR}"
            + @"(?!.*\3))?(?: " + $"{MandatoryArguments}" + @"(?!.*\4))(?: " + $"{ArgumentR}"
            + @"(?!.*\5))?(?: " + $"{MandatoryArguments}" + @"(?!.*\6))(?: " + $"{ArgumentR}"
            + @"(?!.*\7))?(?: " + $"{MandatoryArguments}" + @"(?!.*\8))(?: " + $"{ArgumentR}"
            + @"(?!.*\9))?(?: " + $"{MandatoryArguments}" + @"(?!.*\10))(?: " + $"{ArgumentR}"
            + @"(?!.*\11))?(?: " + $"{MandatoryArguments}" + @"(?!.*\12))(?: " + $"{ArgumentR}"
            + @"(?!.*\13))?(?: " + $"{MandatoryArguments}" + @"(?!.*\14))(?: " + $"{ArgumentR}"
            + @"(?!.*\15))?(?: " + $"{MandatoryArguments}" + @"(?!.*\16))(?: " + $"{ArgumentR}"
            + @"(?!.*\17))?(?: " + $"{MandatoryArguments}" + @"(?!.*\18))(?: " + $"{ArgumentR}"
            + @"(?!.*\19))?$";

        public static string VirtualTime { get; } = "^VR ([1-9]|([012][0-9])|(3[01]))."
            + @"([0]{0,1}[1-9]|1[012]).\d\d\d\d. ([0-1]?[0-9]|2?[0-3]):([0-5]\d):([0-5]\d)$";

        public static string ReservationRequest { get; } = @"^UR ([a-zA-Z_0-9.]+\.csv)$";

        public static string MooringReservationRequest { get; } = @"^ZD \d{1,9}$";

        public static string AvailableMooringRequest { get; } = @"^ZP \d{1,9} ([0]?[1-9]|[1][0-9]|2[0-3])$$";

        public static string MooringsPrint { get; } = @"^V ([A-Z]{2}) (S|Z)( ([1-9]|([012][0-9])|(3[01]))."
            + @"([0]{0,1}[1-9]|1[012]).\d\d\d\d. ([0-1]?[0-9]|2?[0-3]):([0-5]\d):([0-5]\d)){2}$";

        public static string HeaderRow { get; } = @"^([a-zA-Z_]+)(\;[a-zA-Z_]+)*$";

        public static string Moorings { get; } = @"^([0-9]+){1}(,[0-9]+)*$";

        public static string PrintFormat { get; } = @"^T(?: ((?:RB)|[ZP]){1}(?!.*\1))?"
            + @"(?: ((?:RB)|[ZP]){1}(?!.*\2))?(?: ((?:RB)|[ZP]){1}(?!.*\3))?$";

        public static string PrintTakenMoorings { get; } = @"^ZA ([1-9]|([012][0-9])|(3[01]))."
            + @"([0]{0,1}[1-9]|1[012]).\d\d\d\d. ([0-1]?[0-9]|2?[0-3]):([0-5]\d)$";

        public static string ChannelConnection { get; } = @"^F \d{1,9} \d{1,9}(?: Q)*$";

        public static string ShipStatus { get; } = @"^B \d{1,9}$";

        public static string StateBackup { get; } = @"^SPS "".+""$";

        public static string StateRestore { get; } = @"^VPS "".+""$";
    }
}
