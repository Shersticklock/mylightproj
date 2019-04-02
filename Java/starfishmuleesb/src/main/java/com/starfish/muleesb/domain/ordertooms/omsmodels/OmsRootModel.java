package com.starfish.muleesb.domain.ordertooms.omsmodels;

import java.util.List;

import org.codehaus.jackson.annotate.JsonProperty;

public class OmsRootModel {

	@JsonProperty("id")
	private String id;

	@JsonProperty("shop")
	private String shop;

	@JsonProperty("timeCreated")
	private String timeCreated;

	@JsonProperty("discount")
	private Double discount;

	@JsonProperty("discountType")
	private Integer discountType;

	@JsonProperty("lastName")
	private String lastName;

	@JsonProperty("firstName")
	private String firstName;

	@JsonProperty("phone")
	private String phone;

	@JsonProperty("additionalPhone")
	private String additionalPhone;

	@JsonProperty("email")
	private String email;

	@JsonProperty("loyaltyCardId")
	private String loyaltyCardId;

	@JsonProperty("loyaltyBonusEarn")
	private Double loyaltyBonusEarn;

	@JsonProperty("loyaltyBonusBurn")
	private Double loyaltyBonusBurn;

	@JsonProperty("needCall")
	private Boolean needCall;

	@JsonProperty("needSms")
	private Boolean needSms;

	@JsonProperty("customerComment")
	private String customerComment;

	@JsonProperty("customerId")
	private String customerId;

	@JsonProperty("paymentType")
	private String paymentType;

	@JsonProperty("isCanceled")
	private Boolean isCancelled;

	@JsonProperty("timeCanceled")
	private String timeCanceled;

	@JsonProperty("reasonCanceled")
	private String reasonCanceled;

	@JsonProperty("isPaid")
	private Boolean isPaid;

	@JsonProperty("sumPaid")
	private Double sumPaid;

	@JsonProperty("timePaid")
	private String timePaid;

	@JsonProperty("status")
	private String status;

	@JsonProperty("deliveryType")
	private String deliveryType;

	@JsonProperty("deliveryRecipient")
	private String deliveryRecipient;

	@JsonProperty("deliveryCost")
	private Double deliveryCost;

	@JsonProperty("deliveryDate")
	private String deliveryDate;

	@JsonProperty("deliveryTimeFrom")
	private String deliveryTimeFrom;

	@JsonProperty("deliveryTimeTill")
	private String deliveryTimeTill;

	@JsonProperty("deliveryAddress")
	private DeliveryAddressOms deliveryAddress;

	@JsonProperty("items")
	private List<ProductOrderItemFromOms> items;

	@JsonProperty("personalDiscounts")
	private List<PersonalDiscountFromOms> personalDiscounts;

	@JsonProperty("customAttributes")
	private List<CustomAttributeFromOms> customAttributes;


	public String getId() {
		return id;
	}

	public void setId(String id) {
		this.id = id;
	}

	public String getShop() {
		return shop;
	}

	public void setShop(String shop) {
		this.shop = shop;
	}

	public String getTimeCreated() {
		return timeCreated;
	}

	public void setTimeCreated(String timeCreated) {
		this.timeCreated = timeCreated;
	}

	public Double getDiscount() {
		return discount;
	}

	public void setDiscount(Double discount) {
		this.discount = discount;
	}

	public Integer getDiscountType() {
		return discountType;
	}

	public void setDiscountType(Integer discountType) {
		this.discountType = discountType;
	}

	public String getLastName() {
		return lastName;
	}

	public void setLastName(String lastName) {
		this.lastName = lastName;
	}

	public String getFirstName() {
		return firstName;
	}

	public void setFirstName(String firstName) {
		this.firstName = firstName;
	}

	public String getPhone() {
		return phone;
	}

	public void setPhone(String phone) {
		this.phone = phone;
	}

	public String getAdditionalPhone() {
		return additionalPhone;
	}

	public void setAdditionalPhone(String additionalPhone) {
		this.additionalPhone = additionalPhone;
	}

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public Double getLoyaltyBonusEarn() {
		return loyaltyBonusEarn;
	}

	public void setLoyaltyBonusEarn(Double loyaltyBonusEarn) {
		this.loyaltyBonusEarn = loyaltyBonusEarn;
	}

	public Double getLoyaltyBonusBurn() {
		return loyaltyBonusBurn;
	}

	public void setLoyaltyBonusBurn(Double loyaltyBonusBurn) {
		this.loyaltyBonusBurn = loyaltyBonusBurn;
	}

	public Boolean getNeedCall() {
		return needCall;
	}

	public void setNeedCall(Boolean needCall) {
		this.needCall = needCall;
	}

	public Boolean getNeedSms() {
		return needSms;
	}

	public void setNeedSms(Boolean needSms) {
		this.needSms = needSms;
	}

	public String getCustomerComment() {
		return customerComment;
	}

	public void setCustomerComment(String customerComment) {
		this.customerComment = customerComment;
	}

	public String getCustomerId() {
		return customerId;
	}

	public void setCustomerId(String customerId) {
		this.customerId = customerId;
	}

	public String getPaymentType() {
		return paymentType;
	}

	public void setPaymentType(String paymentType) {
		this.paymentType = paymentType;
	}

	public Boolean getIsCancelled() {
		return isCancelled;
	}

	public void setIsCancelled(Boolean isCancelled) {
		this.isCancelled = isCancelled;
	}

	public String getTimeCanceled() {
		return timeCanceled;
	}

	public void setTimeCanceled(String timeCanceled) {
		this.timeCanceled = timeCanceled;
	}

	public String getReasonCanceled() {
		return reasonCanceled;
	}

	public void setReasonCanceled(String reasonCanceled) {
		this.reasonCanceled = reasonCanceled;
	}

	public Boolean getIsPaid() {
		return isPaid;
	}

	public void setIsPaid(Boolean isPaid) {
		this.isPaid = isPaid;
	}

	public Double getSumPaid() {
		return sumPaid;
	}

	public void setSumPaid(Double sumPaid) {
		this.sumPaid = sumPaid;
	}

	public String getTimePaid() {
		return timePaid;
	}

	public void setTimePaid(String timePaid) {
		this.timePaid = timePaid;
	}

	public String getStatus() {
		return status;
	}

	public void setStatus(String status) {
		this.status = status;
	}

	public String getDeliveryType() {
		return deliveryType;
	}

	public void setDeliveryType(String deliveryType) {
		this.deliveryType = deliveryType;
	}

	public String getDeliveryRecipient() {
		return deliveryRecipient;
	}

	public void setDeliveryRecipient(String deliveryRecipient) {
		this.deliveryRecipient = deliveryRecipient;
	}

	public Double getDeliveryCost() {
		return deliveryCost;
	}

	public void setDeliveryCost(Double deliveryCost) {
		this.deliveryCost = deliveryCost;
	}

	public String getDeliveryDate() {
		return deliveryDate;
	}

	public void setDeliveryDate(String deliveryDate) {
		this.deliveryDate = deliveryDate;
	}

	public String getDeliveryTimeFrom() {
		return deliveryTimeFrom;
	}

	public void setDeliveryTimeFrom(String deliveryTimeFrom) {
		this.deliveryTimeFrom = deliveryTimeFrom;
	}

	public String getDeliveryTimeTill() {
		return deliveryTimeTill;
	}

	public void setDeliveryTimeTill(String deliveryTimeTill) {
		this.deliveryTimeTill = deliveryTimeTill;
	}

	public DeliveryAddressOms getDeliveryAddress() {
		return deliveryAddress;
	}

	public void setDeliveryAddress(DeliveryAddressOms deliveryAddress) {
		this.deliveryAddress = deliveryAddress;
	}

	public List<ProductOrderItemFromOms> getItems() {
		return items;
	}

	public void setItems(List<ProductOrderItemFromOms> items) {
		this.items = items;
	}

	public List<PersonalDiscountFromOms> getPersonalDiscounts() {
		return personalDiscounts;
	}

	public void setPersonalDiscounts(List<PersonalDiscountFromOms> personalDiscounts) {
		this.personalDiscounts = personalDiscounts;
	}

	public List<CustomAttributeFromOms> getCustomAttributes() {
		return customAttributes;
	}

	public void setCustomAttributes(List<CustomAttributeFromOms> customAttributes) {
		this.customAttributes = customAttributes;
	}

	public String getLoyaltyCardId() {
		return loyaltyCardId;
	}

	public void setLoyaltyCardId(String loyaltyCardId) {
		this.loyaltyCardId = loyaltyCardId;
	}

}
