using MathOperations;
using System.Activities.Presentation.Metadata;
using System.ComponentModel;


namespace ActMathOperations
{
    public class DesignerMetadata : IRegisterMetadata
    {
        public void Register()
        {
            AttributeTableBuilder attributeTableBuilder = new AttributeTableBuilder();
            attributeTableBuilder.AddCustomAttributes(typeof(SimpleFormula), new DesignerAttribute(typeof(ActivityDesigner1)));
            MetadataStore.AddAttributeTable(attributeTableBuilder.CreateTable());
        }
    }
}