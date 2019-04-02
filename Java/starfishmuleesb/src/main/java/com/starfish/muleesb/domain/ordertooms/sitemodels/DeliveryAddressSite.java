package com.starfish.muleesb.domain.ordertooms.sitemodels;

import org.codehaus.jackson.annotate.JsonProperty;

public class DeliveryAddressSite {

	@JsonProperty("GUID_Customer")
	private String customerGuid;

	@JsonProperty("LastName")
	private String lastName;

	@JsonProperty("FirstName")
	private String firstName;

	@JsonProperty("MobilePhone")
	private String mobilePhone;

	@JsonProperty("City")
	private String city;

	@JsonProperty("CityId")
	private String cityId;

	@JsonProperty("Street")
	private String street;

	@JsonProperty("House")
	private String house;

	@JsonProperty("Building")
	private String building;

	@JsonProperty("Gate")
	private String gate;

	@JsonProperty("Room")
	private String room;

	@JsonProperty("Index")
	private String index;

	@JsonProperty("DeliveryComment")
	private String deliveryComment;


	public String getCustomerGuid() {
		return customerGuid;
	}

	public void setCustomerGuid(String customerGuid) {
		this.customerGuid = customerGuid;
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

	public String getMobilePhone() {
		return mobilePhone;
	}

	public void setMobilePhone(String mobilePhone) {
		this.mobilePhone = mobilePhone;
	}

	public String getCity() {
		return city;
	}

	public void setCity(String city) {
		this.city = city;
	}

	public String getCityId() {
		return cityId;
	}

	public void setCityId(String cityId) {
		this.cityId = cityId;
	}

	public String getStreet() {
		return street;
	}

	public void setStreet(String street) {
		this.street = street;
	}

	public String getHouse() {
		return house;
	}

	public void setHouse(String house) {
		this.house = house;
	}

	public String getBuilding() {
		return building;
	}

	public void setBuilding(String building) {
		this.building = building;
	}

	public String getGate() {
		return gate;
	}

	public void setGate(String gate) {
		this.gate = gate;
	}

	public String getRoom() {
		return room;
	}

	public void setRoom(String room) {
		this.room = room;
	}

	public String getIndex() {
		return index;
	}

	public void setIndex(String index) {
		this.index = index;
	}

	public String getDeliveryComment() {
		return deliveryComment;
	}

	public void setDeliveryComment(String deliveryComment) {
		this.deliveryComment = deliveryComment;
	}

}
