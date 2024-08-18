using Francisco_Moreira.Controllers;
using Francisco_Moreira.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Francisco_Moreira.Tests
{
    [TestClass]
    public class TareasControllerTests
    {
        private TareasController controller;
        [TestInitialize]
        public void Setup()
        {     
            controller = new TareasController();
        }
        
        [TestMethod]
        public void Edit_Post_ValidData_UpdatesTaskAndRedirectsToIndex()
        {
            
            var tarea = new Tarea
            {
                ID = 10,
                Titulo = "Tarea Original",
                Descripcion = "Descripción Original",
                FechaVencimiento = DateTime.Now.AddDays(5),
                Completada = false
            };

            
            var updatedTarea = new Tarea
            {
                ID = 10,
                Titulo = "Tarea Actualizada",
                Descripcion = "Descripción Actualizada",
                FechaVencimiento = DateTime.Now.AddDays(10),
                Completada = true
            };
           
            var result = controller.Edit(1, updatedTarea) as RedirectToRouteResult;
            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.RouteValues["action"]);
        }
        [TestMethod]
        public void Create_Post_ValidData_RedirectsToIndex()
        {            
            var tarea = new Tarea
            {
                Titulo = "Nueva Tarea",
                Descripcion = "Descripción de prueba",
                FechaVencimiento = DateTime.Now.AddDays(1),
                Completada = false
            };         
            var result = controller.Create(tarea) as RedirectToRouteResult;        
            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.RouteValues["action"]);
        }
    }
}
