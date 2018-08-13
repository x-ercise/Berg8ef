using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Berg8.EF.Configuration
{
    public class CommandItemConfiguration : EntityTypeConfiguration<Berg8.Model.DTO.CommandItem>
    {
        private CommandItemConfiguration(string schema)
        {
            string tableName = string.Format("{0}.{1}", schema, "TB_COMMAND_ITEM");
            ToTable(tableName);
            HasKey(x => x.ID);

            Property(x => x.ID).HasColumnName("COMMAND_ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            
            Property(x => x.CreatedDate).HasColumnName("CREATED_DATE").IsOptional().HasColumnType("datetime");
            Property(x => x.CreatedBy).HasColumnName("CREATED_BY").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.UpdatedDate).HasColumnName("UPDATED_DATE").IsOptional().HasColumnType("datetime");
            Property(x => x.UpdatedBy).HasColumnName("UPDATED_BY").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);

        }

        public static CommandItemConfiguration CreateInstance(string schema)
        {
            CommandItemConfiguration instance = new CommandItemConfiguration(schema);
            return instance;
        }
    }
}
