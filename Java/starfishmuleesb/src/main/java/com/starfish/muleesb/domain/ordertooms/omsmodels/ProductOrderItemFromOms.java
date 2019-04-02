package com.starfish.muleesb.domain.ordertooms.omsmodels;

import java.util.List;

import org.codehaus.jackson.annotate.JsonProperty;

public class ProductOrderItemFromOms {

	@JsonProperty("price")
	private Double price;

	@JsonProperty("discount")
	private Double discount;

	@JsonProperty("quantity")
	private Integer quantity;

	@JsonProperty("fixedWeight")
	private Double fixedWeight;

	@JsonProperty("estimatedWeight")
	private Double estimatedWeight;

	@JsonProperty("name")
	private String name;

	@JsonProperty("productId")
	private String productId;

	@JsonProperty("customAttributes")
	private List<CustomAttributeFromOms> customAttributes;


	public Double getPrice() {
		return price;
	}

	public void setPrice(Double price) {
		this.price = price;
	}

	public Double getDiscount() {
		return discount;
	}

	public void setDiscount(Double discount) {
		this.discount = discount;
	}

	public Integer getQuantity() {
		return quantity;
	}

	public void setQuantity(Integer quantity) {
		this.quantity = quantity;
	}

	public Double getFixedWeight() {
		return fixedWeight;
	}

	public void setFixedWeight(Double fixedWeight) {
		this.fixedWeight = fixedWeight;
	}

	public Double getEstimatedWeight() {
		return estimatedWeight;
	}

	public void setEstimatedWeight(Double estimatedWeight) {
		this.estimatedWeight = estimatedWeight;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getProductId() {
		return productId;
	}

	public void setProductId(String productId) {
		this.productId = productId;
	}

	public List<CustomAttributeFromOms> getCustomAttributes() {
		return customAttributes;
	}

	public void setCustomAttributes(List<CustomAttributeFromOms> customAttributes) {
		this.customAttributes = customAttributes;
	}

}
