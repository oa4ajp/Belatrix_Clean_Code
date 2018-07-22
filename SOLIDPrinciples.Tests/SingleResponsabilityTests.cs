using SOLID._01_SingleResponsability;
using SOLID._02_OpenClosed;
using System;
using Xunit;

namespace SOLIDPrinciples.Tests
{
    
    public class SingleResponsabilityTests
    {
        [Fact]
        public void Validar_Suma_Correcta()
        {
            var calcultor = new Calculator();
            calcultor.Sum(5 , 6);            
        }
    }
}
