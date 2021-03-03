using NUnit.Framework;
using ProjetoContratos.Domain.DTO;
using ProjetoContratos.Domain.Entity;
using ProjetoContratos.Domain.Enum;
using System;

namespace ProjetoContratos.Test
{
    public class Tests
    {
        [Test]
        public void ValidarStatusAbertoTest()
        {
            // Arrange
            PrestacaoDto prestacao = new PrestacaoDto
            {
                DataVencimento = DateTime.Now.Date.AddDays(3),
                DataPagamento = null
            };

            // Act
            StatusPrestacao status = prestacao.Status;

            // Assert
            Assert.AreEqual(StatusPrestacao.Aberta, status);
        }

        [Test]
        public void ValidarStatusVencidoTest()
        {
            // Arrange
            PrestacaoDto prestacao = new PrestacaoDto
            {
                DataVencimento = DateTime.Now.Date.AddDays(-3),
                DataPagamento = null
            };

            // Act
            StatusPrestacao status = prestacao.Status;

            // Assert
            Assert.AreEqual(StatusPrestacao.Atrasada, status);
        }

        [Test]
        public void ValidarStatusBaixadoTest()
        {
            // Arrange
            PrestacaoDto prestacao = new PrestacaoDto
            {
                DataVencimento = DateTime.Now.Date.AddDays(-3),
                DataPagamento = DateTime.Now.Date.AddDays(-5)
            };

            // Act
            StatusPrestacao status = prestacao.Status;

            // Assert
            Assert.AreEqual(StatusPrestacao.Baixada, status);
        }
    }
}