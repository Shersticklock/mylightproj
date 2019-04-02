package com.starfish.muleesb.domain.productupdate;

import java.util.List;

import com.fasterxml.jackson.annotation.JsonInclude;

@JsonInclude(JsonInclude.Include.NON_NULL)
public class ProductJson {
	
	private String id;
	private String name;
	private Boolean active;
	private String article;
	private String productCategoryId;
	private String description;
	private String vendor;
	private String imageUrl;
	private String productUrl;
	private String itemType;
	private Double normalWeight;
	private String parentId;
	private List<CustomAttribute> customAttributes;
	
	
	public String getId() {
		return id;
	}
	
	public void setId(String id) {
		this.id = id;
	}
	
	public String getName() {
		return name;
	}
	
	public void setName(String name) {
		this.name = name;
	}
	
	public Boolean getActive() {
		return active;
	}
	
	public void setActive(Boolean active) {
		this.active = active;
	}
	
	public String getArticle() {
		return article;
	}
	
	public void setArticle(String article) {
		this.article = article;
	}
	
	public String getProductCategoryId() {
		return productCategoryId;
	}
	
	public void setProductCategoryId(String productCategoryId) {
		this.productCategoryId = productCategoryId;
	}
	
	public String getDescription() {
		return description;
	}
	
	public void setDescription(String description) {
		this.description = description;
	}
	
	public String getVendor() {
		return vendor;
	}
	
	public void setVendor(String vendor) {
		this.vendor = vendor;
	}
	
	public String getImageUrl() {
		return imageUrl;
	}
	
	public void setImageUrl(String imageUrl) {
		this.imageUrl = imageUrl;
	}
	
	public String getProductUrl() {
		return productUrl;
	}
	
	public void setProductUrl(String productUrl) {
		this.productUrl = productUrl;
	}
	
	public String getItemType() {
		return itemType;
	}
	
	public void setItemType(String itemType) {
		this.itemType = itemType;
	}
	
	public Double getNormalWeight() {
		return normalWeight;
	}
	
	public void setNormalWeight(Double normalWeight) {
		this.normalWeight = normalWeight;
	}
	
	public String getParentId() {
		return parentId;
	}
	
	public void setParentId(String parentId) {
		this.parentId = parentId;
	}
	
	public List<CustomAttribute> getCustomAttributes() {
		return customAttributes;
	}
	
	public void setCustomAttributes(List<CustomAttribute> customAttributes) {
		this.customAttributes = customAttributes;
	}

}
