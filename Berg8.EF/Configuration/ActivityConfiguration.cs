using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Berg8.EF.Configuration
{
    public class ActivityConfiguration : EntityTypeConfiguration<Berg8.Model.DTO.Activity>
    {
        private ActivityConfiguration(string schema)
        {
            string tableName = string.Format("{0}.{1}", schema, "TB_ACTIVITY");
            ToTable(tableName);
            HasKey(x => x.ID);

            Property(x => x.ID).HasColumnName("ACTIVITY_ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ActivityName).HasColumnName("ACTIVITY_NAME").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);

            Property(x => x.CreatedDate).HasColumnName("CREATED_DATE").IsOptional().HasColumnType("datetime");
            Property(x => x.CreatedBy).HasColumnName("CREATED_BY").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.UpdatedDate).HasColumnName("UPDATED_DATE").IsOptional().HasColumnType("datetime");
            Property(x => x.UpdatedBy).HasColumnName("UPDATED_BY").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);

        }

        public static ActivityConfiguration CreateInstance(string schema)
        {
            ActivityConfiguration instance = new ActivityConfiguration(schema);
            return instance;
        }
    }
}
