package com.starfish.muleesb.domain.ordertooms.sitemodels;

import org.codehaus.jackson.annotate.JsonProperty;

public class ProductOrderItemFromSite {

	@JsonProperty("IdProduct")
	private String productId;

	@JsonProperty("IdSize")
	private String sizeId;

	@JsonProperty("Quantity")
	private Integer quantity;

	@JsonProperty("PriceInitial")
	private Double priceInitial;

	@JsonProperty("Price")
	private Double price;


	public String getProductId() {
		return productId;
	}

	public void setProductId(String productId) {
		this.productId = productId;
	}

	public String getSizeId() {
		return sizeId;
	}

	public void setSizeId(String sizeId) {
		this.sizeId = sizeId;
	}

	public Integer getQuantity() {
		return quantity;
	}

	public void setQuantity(Integer quantity) {
		this.quantity = quantity;
	}

	public Double getPriceInitial() {
		return priceInitial;
	}

	public void setPriceInitial(Double priceInitial) {
		this.priceInitial = priceInitial;
	}

	public Double getPrice() {
		return price;
	}

	public void setPrice(Double price) {
		this.price = price;
	}

}
