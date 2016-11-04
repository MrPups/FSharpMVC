namespace FSharpMVCWebAPI.DAL
    open System.ComponentModel
    open System.ComponentModel.DataAnnotations
    open System.Data.Entity

    type EFDatabase() =
        inherit DbContext()

        [<DefaultValue>]
        let mutable m_Products : DbSet<Product>

        member public X.Products   with get() = X.m_Products
                                   and  set v = X.m_Products <- v