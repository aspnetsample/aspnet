// <auto-generated />
namespace ODataVersioningSample.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    public sealed partial class upgradetov2models : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(upgradetov2models));
        
        string IMigrationMetadata.Id
        {
            get { return "201302151955114_upgrade to v2 models"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
