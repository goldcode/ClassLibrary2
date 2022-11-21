using DeviceId;
using DeviceId.Encoders;
using DeviceId.Formatters;
using NUnit.Framework;

namespace ClassLibrary2
{
    public class Class1
    {
        [Test]
        public void Test()
        {
            var deviceIdXml = new DeviceIdBuilder()
                .OnWindows(windows => windows
                    .AddMotherboardSerialNumber()
                    .AddMacAddressFromWmi(excludeWireless: true, excludeNonPhysical: true))
                    .UseFormatter(new XmlDeviceIdFormatter(new PlainTextDeviceIdComponentEncoder()))
                    .ToString();
            Console.WriteLine(deviceIdXml);
        }
    }
}