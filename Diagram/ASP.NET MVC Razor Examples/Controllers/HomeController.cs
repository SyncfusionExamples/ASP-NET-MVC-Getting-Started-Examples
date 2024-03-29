﻿using Syncfusion.EJ2.Diagrams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diagram.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<DiagramNode> Nodes = new List<DiagramNode>();
            List<DiagramNodeAnnotation> Node1 = new List<DiagramNodeAnnotation>();
            Node1.Add(new DiagramNodeAnnotation() { Content = "node1" });
            List<DiagramNodeAnnotation> Node2 = new List<DiagramNodeAnnotation>();
            Node2.Add(new DiagramNodeAnnotation() { Content = "node2" });
            List<DiagramNodeAnnotation> Node3 = new List<DiagramNodeAnnotation>();
            Nodes.Add(new DiagramNode()
            {
                Id = "node1",
                Annotations = Node1,
                Style = new NodeStyleNodes() { Fill = "darkcyan" },
                OffsetX = 100,
                OffsetY = 100,
                Width = 100,
                Height = 100

            });
            Nodes.Add(new DiagramNode()
            {
                Id = "node2",
                Annotations = Node2,
                Style = new NodeStyleNodes() { Fill = "darkcyan" },
                OffsetX = 300,
                OffsetY = 100,
                Width = 100,
                Height = 100
            });
            List<DiagramConnector> Connectors = new List<DiagramConnector>();
            Connectors.Add(new DiagramConnector() { Id = "connector", SourceID = "node1", TargetID = "node2", });
            ViewBag.nodes = Nodes;
            ViewBag.connectors = Connectors;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
    public class Node : DiagramNode
    {
        public string text;
    }
}