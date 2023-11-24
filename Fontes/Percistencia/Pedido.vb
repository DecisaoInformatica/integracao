Namespace Shopee
    Public Class ImageInfo
        Public Property image_url As String
    End Class

    Public Class ItemList
        Public Property item_id As Integer
        Public Property item_name As String
        Public Property item_sku As String
        Public Property model_id As Integer
        Public Property model_name As String
        Public Property model_sku As String
        Public Property model_quantity_purchased As Integer
        Public Property model_original_price As Integer
        Public Property model_discounted_price As Integer
        Public Property wholesale As Boolean
        Public Property weight As Double
        Public Property add_on_deal As Boolean
        Public Property main_item As Boolean
        Public Property add_on_deal_id As Integer
        Public Property promotion_type As String
        Public Property promotion_id As Integer
        Public Property order_item_id As Integer
        Public Property promotion_group_id As Integer
        Public Property image_info As ImageInfo
        Public Property product_location_id As List(Of Object)
        Public Property is_prescription_item As Boolean
        Public Property is_b2c_owned_item As Boolean
    End Class

    Public Class OrderList
        Public Property actual_shipping_fee As Integer
        Public Property buyer_cpf_id As Object
        Public Property buyer_user_id As Integer
        Public Property buyer_username As String
        Public Property cod As Boolean
        Public Property create_time As Integer
        Public Property currency As String
        Public Property days_to_ship As Integer
        Public Property dropshipper As Object
        Public Property dropshipper_phone As Object
        Public Property estimated_shipping_fee As Integer
        Public Property item_list As List(Of ItemList)
        Public Property message_to_seller As String
        Public Property order_sn As String
        Public Property order_status As String
        Public Property recipient_address As RecipientAddress
        Public Property region As String
        Public Property reverse_shipping_fee As Integer
        Public Property ship_by_date As Integer
        Public Property update_time As Integer
    End Class

    Public Class RecipientAddress
        Public Property name As String
        Public Property phone As String
        Public Property town As String
        Public Property district As String
        Public Property city As String
        Public Property state As String
        Public Property region As String
        Public Property zipcode As String
        Public Property full_address As String
    End Class

    Public Class Pedido
        Public Property order_list As List(Of OrderList)
    End Class

End Namespace

