package com.starfish.muleesb.domain.ordertooms.sitemodels;

import java.util.List;

import org.codehaus.jackson.annotate.JsonProperty;

public class SiteRootModel {

	@JsonProperty("OrderID")
	private String orderId;

	@JsonProperty("GUID_Order")
	private String orderGuid;

	@JsonProperty("DateCreateIS")
	private String dateCreateIS;

	@JsonProperty("DeliveryCost")
	private Double deliveryCost;

	@JsonProperty("GUID_ShippingType")
	private String shippingType;

	@JsonProperty("GUID_PaymentType")
	private String paymentType;

	@JsonProperty("GUID_StoreHouse")
	private String storeHouse;

	@JsonProperty("GUID_DiscontCard")
	private String discountCard;

	@JsonProperty("GUID_StatusOrder")
	private String statusOrder;

	@JsonProperty("DatePayment")
	private String dateOfPayment;

	@JsonProperty("SummaPayment")
	private Double summaPayment;

	@JsonProperty("ContactIS")
	private DeliveryAddressSite contactIS;

	@JsonProperty("BonusCalculated")
	private Double bonusCalculated;

	@JsonProperty("BonusClosed")
	private Double bonusClosed;

	@JsonProperty("Goods")
	private List<ProductOrderItemFromSite> goods;

	@JsonProperty("ManualDiscounts")
	private List<DiscountFromSite> manualDiscounts;

	@JsonProperty("Discounts")
	private List<DiscountFromSite> discounts;

	public String getOrderId() {
		return orderId;
	}

	public void setOrderId(String orderId) {
		this.orderId = orderId;
	}

	public String getOrderGuid() {
		return orderGuid;
	}

	public void setOrderGuid(String orderGuid) {
		this.orderGuid = orderGuid;
	}

	public String getDateCreateIS() {
		return dateCreateIS;
	}

	public void setDateCreateIS(String dateCreateIS) {
		this.dateCreateIS = dateCreateIS;
	}

	public Double getDeliveryCost() {
		return deliveryCost;
	}

	public void setDeliveryCost(Double deliveryCost) {
		this.deliveryCost = deliveryCost;
	}

	public String getShippingType() {
		return shippingType;
	}

	public void setShippingType(String shippingType) {
		this.shippingType = shippingType;
	}

	public String getPaymentType() {
		return paymentType;
	}

	public void setPaymentType(String paymentType) {
		this.paymentType = paymentType;
	}

	public String getStoreHouse() {
		return storeHouse;
	}

	public void setStoreHouse(String storeHouse) {
		this.storeHouse = storeHouse;
	}

	public String getDiscountCard() {
		return discountCard;
	}

	public void setDiscountCard(String discountCard) {
		this.discountCard = discountCard;
	}

	public String getStatusOrder() {
		return statusOrder;
	}

	public void setStatusOrder(String statusOrder) {
		this.statusOrder = statusOrder;
	}

	public String getDateOfPayment() {
		return dateOfPayment;
	}

	public void setDateOfPayment(String dateOfPayment) {
		this.dateOfPayment = dateOfPayment;
	}

	public Double getSummaPayment() {
		return summaPayment;
	}

	public void setSummaPayment(Double summaPayment) {
		this.summaPayment = summaPayment;
	}

	public DeliveryAddressSite getContactIS() {
		return contactIS;
	}

	public void setContactIS(DeliveryAddressSite contactIS) {
		this.contactIS = contactIS;
	}

	public Double getBonusCalculated() {
		return bonusCalculated;
	}

	public void setBonusCalculated(Double bonusCalculated) {
		this.bonusCalculated = bonusCalculated;
	}

	public Double getBonusClosed() {
		return bonusClosed;
	}

	public void setBonusClosed(Double bonusClosed) {
		this.bonusClosed = bonusClosed;
	}

	public List<ProductOrderItemFromSite> getGoods() {
		return goods;
	}

	public void setGoods(List<ProductOrderItemFromSite> goods) {
		this.goods = goods;
	}

	public List<DiscountFromSite> getManualDiscounts() {
		return manualDiscounts;
	}

	public void setManualDiscounts(List<DiscountFromSite> manualDiscounts) {
		this.manualDiscounts = manualDiscounts;
	}

	public List<DiscountFromSite> getDiscounts() {
		return discounts;
	}

	public void setDiscounts(List<DiscountFromSite> discounts) {
		this.discounts = discounts;
	}

}
