
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Dunno
{

using System;
    using System.Collections.Generic;
    
public partial class BienLai
{

    public string MaBienLai { get; set; }

    public string MaHocVien { get; set; }

    public string MaLopHoc { get; set; }

    public string TinhTrang { get; set; }



    public virtual HocVien HocVien { get; set; }

    public virtual LopHoc LopHoc { get; set; }

}

}
