using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Berg8.EF.Configuration
{

    public class WorkflowConfigulartion : EntityTypeConfiguration<Berg8.Model.DTO.Workflow>
    {
        private WorkflowConfigulartion(string schema)
        {
            string tableName = string.Format("{0}.{1}", schema, "TB_WORKFLOW");
            ToTable(tableName);
            HasKey(x => x.ID);

            Property(x => x.ID).HasColumnName("WORKFLOW_ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Description).HasColumnName("DESCRIPTION").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(1000);
            Property(x => x.CreatedDate).HasColumnName("CREATED_DATE").IsOptional().HasColumnType("datetime");
            Property(x => x.CreatedBy).HasColumnName("CREATED_BY").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.UpdatedDate).HasColumnName("UPDATED_DATE").IsOptional().HasColumnType("datetime");
            Property(x => x.UpdatedBy).HasColumnName("UPDATED_BY").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);

        }

        public static WorkflowConfigulartion CreateInstance(string schema)
        {
            WorkflowConfigulartion instance = new WorkflowConfigulartion(schema);
            return instance;
        }
    }
}
