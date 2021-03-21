using System.Collections.Generic;

namespace HexUML.PlantUmlRenderer.Diagrams.Component
{
    public class ComponentDiagram : Diagram
    {
        List<Component> Components { get; }
        List<Interface> Interfaces { get; }
        List<Relation> Relations { get; }
        public ComponentDiagram(string title, string description) : base(title, description)
        {
            Components = new();
            Interfaces = new();
            Relations = new();
        }

        public override string ToString()
        {
            throw new System.NotImplementedException();
            //TODO: 1. Call HexUMLService PlantUMLParser with the current object and configuration 2. Return code to render
        }
    }
}