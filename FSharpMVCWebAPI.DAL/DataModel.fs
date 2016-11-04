namespace FSharpMVCWebAPI.DAL
    open System.ComponentModel.DataAnnotations
    open System.Data.Entity


    type Product() = 
        let mutable m_ID    : int = 0
        let mutable m_Name  : string = ""
        let mutable m_Price : float = 0.0

        [<Key>]
        member public X.ID    with get() = m_ID
                              and  set v = m_ID <- v
        member public X.Name  with get() = m_Name
                              and  set v = m_Name <- v
        member public X.Price with get() = m_Price
                              and  set v = m_Price <- v