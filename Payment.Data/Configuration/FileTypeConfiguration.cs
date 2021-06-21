using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Payment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Data.Configuration
{
    public class FileTypeConfiguration : IEntityTypeConfiguration<FileType>
    {
        public void Configure(EntityTypeBuilder<FileType> builder)
        {
            builder.HasKey(x => x.code);

            builder.HasData(new FileType()
            {
                code = "CMND",
                name = "Chứng minh nhân dân",
                allowExtension = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*",
            });

            builder.HasData(new FileType()
            {
                code = "CCCD",
                name = "Căn cước công dân",
                allowExtension = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*",
            });

            builder.HasData(new FileType()
            {
                code = "HC",
                name = "Hộ chiếu",
                allowExtension = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*",
            });

            builder.HasData(new FileType()
            {
                code = "GPLX",
                name = "Bằng lái xe",
                allowExtension = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*",
            });

            builder.HasData(new FileType()
            {
                code = "CI",
                name = "Import khách hàng",
                allowExtension = "Excel|*.xls|Excel 2010|*.xlsx",
            });
        }
    }
}
