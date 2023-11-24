Namespace Shopee
    Public Class Produto
        Public Property item_id As Integer
        Public Property category_id As Integer
        Public Property item_name As String
        Public Property item_sku As String
        Public Property create_time As Integer
        Public Property update_time As Integer
        Public Property price_info As List(Of PriceInfo)
        Public Property image As Image
        Public Property weight As String
        Public Property dimension As Dimension
        Public Property logistic_info As List(Of LogisticInfo)
        Public Property pre_order As PreOrder
        Public Property condition As String
        Public Property size_chart As String
        Public Property item_status As String
        Public Property has_model As Boolean
        Public Property promotion_id As Integer
        Public Property brand As Brand
        Public Property item_dangerous As Integer
        Public Property description_info As DescriptionInfo
        Public Property description_type As String
        Public Property stock_info_v2 As StockInfoV2
        Public Property gtin_code As String
        Public Property size_chart_id As Integer
    End Class
    Public Class Brand
        Public Property brand_id As Integer
        Public Property original_brand_name As String
    End Class

    Public Class DescriptionInfo
        Public Property extended_description As ExtendedDescription
    End Class

    Public Class Dimension
        Public Property package_length As Integer
        Public Property package_width As Integer
        Public Property package_height As Integer
    End Class

    Public Class ExtendedDescription
        Public Property field_list As List(Of FieldList)
    End Class

    Public Class FieldList
        Public Property field_type As String
        Public Property text As String
    End Class

    Public Class Image
        Public Property image_id_list As List(Of String)
        Public Property image_url_list As List(Of String)
    End Class

    Public Class LogisticInfo
        Public Property logistic_id As Integer
        Public Property logistic_name As String
        Public Property enabled As Boolean
        Public Property size_id As Integer
        Public Property is_free As Boolean
        Public Property estimated_shipping_fee As Integer
    End Class

    Public Class PreOrder
        Public Property is_pre_order As Boolean
        Public Property days_to_ship As Integer
    End Class

    Public Class PriceInfo
        Public Property currency As String
        Public Property original_price As Integer
        Public Property current_price As Integer
    End Class

    Public Class SellerStock
        Public Property location_id As String
        Public Property stock As Integer
    End Class

    Public Class ShopeeStock
        Public Property location_id As String
        Public Property stock As Integer
    End Class

    Public Class StockInfoV2
        Public Property summary_info As SummaryInfo
        Public Property seller_stock As List(Of SellerStock)
        Public Property shopee_stock As List(Of ShopeeStock)
    End Class

    Public Class SummaryInfo
        Public Property total_reserved_stock As Integer
        Public Property total_available_stock As Integer
    End Class

End Namespace

