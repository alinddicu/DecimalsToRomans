﻿namespace DecimalsToRomans
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class DecimalsToRomansConverterTest
    {
        // I II III IV V VI VII VIII IX X
        // X XX XXX XL L LI LII LIII IL C
        // C CC CCC CD C DC DCC DCCC CM M
        // M MM MMM

        private readonly  DecimalsToRomansConverter _converter = new DecimalsToRomansConverter();

        [TestMethod]
        public void GivenBaseDecimalsWhenConvertThenDecimalsConvertToRomans()
        {
            var conversionMap = _converter.ConversionMap;
            foreach(var dec in conversionMap.Keys)
            {
                Check.That(_converter.Convert(dec)).Equals(conversionMap[dec]);
            }
        }

        [TestMethod]
        public void WhenConvert30ThenReturnXXX()
        {
            Check.That(_converter.Convert(30)).Equals("XXX");
        }
    }
}