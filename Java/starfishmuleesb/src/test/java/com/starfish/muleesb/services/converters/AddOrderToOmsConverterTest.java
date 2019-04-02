package com.starfish.muleesb.services.converters;

import static org.junit.Assert.*;

import java.util.ArrayList;
import java.util.List;

import org.junit.Test;

import com.starfish.muleesb.domain.ordertooms.omsmodels.OmsRootModel;
import com.starfish.muleesb.domain.ordertooms.omsmodels.PersonalDiscountFromOms;
import com.starfish.muleesb.domain.ordertooms.omsmodels.ProductOrderItemFromOms;
import com.starfish.muleesb.domain.ordertooms.sitemodels.DeliveryAddressSite;
import com.starfish.muleesb.domain.ordertooms.sitemodels.DiscountFromSite;
import com.starfish.muleesb.domain.ordertooms.sitemodels.ProductOrderItemFromSite;
import com.starfish.muleesb.domain.ordertooms.sitemodels.SiteRootModel;

public class AddOrderToOmsConverterTest {

	@Test
	public void test() {
		AddOrderToOmsConverter converter = new AddOrderToOmsConverter();
		OmsRootModel result = converter.convert(prepareData());
		
		assertEquals("orderIdValue", result.getId());
		
		assertTrue(result.getCustomAttributes() != null && result.getCustomAttributes().size() == 1);
		assertEquals("order_guid", result.getCustomAttributes().get(0).getName());
		assertEquals("orderGuidValue", result.getCustomAttributes().get(0).getValue());
		
		assertEquals("2017-07-19 13:00:34", result.getTimeCreated());
		assertTrue(123.45 == result.getDeliveryCost());
		assertEquals("shippingTypeValue", result.getDeliveryType());
		assertEquals("paymentTypeValue", result.getPaymentType());
		assertEquals("storeHouseValue", result.getDeliveryAddress().getPickupShop());
		assertEquals("discountCardValue", result.getLoyaltyCardId());
		assertEquals("statusOrderValue", result.getStatus());
		assertEquals("2017-08-19 00:00:00", result.getTimePaid());
		assertTrue(result.getIsPaid());
		assertTrue(234.56 == result.getSumPaid());
		
		assertEquals("customerGuid", result.getCustomerId());
		assertEquals("lastName", result.getLastName());
		assertEquals("firstName", result.getFirstName());
		assertEquals("mobilePhone", result.getPhone());
		assertEquals("city", result.getDeliveryAddress().getCity());
		assertEquals("cityId", result.getDeliveryAddress().getCityId());
		assertEquals("street", result.getDeliveryAddress().getStreet());
		assertEquals("house", result.getDeliveryAddress().getBuilding());
		assertEquals("building", result.getDeliveryAddress().getHousing());
		assertEquals("gate", result.getDeliveryAddress().getGate());
		assertEquals("room", result.getDeliveryAddress().getFlat());
		assertEquals("index", result.getDeliveryAddress().getZip());
		assertEquals("deliveryComment", result.getCustomerComment());
		
		assertTrue(345.67 == result.getLoyaltyBonusEarn());
		assertTrue(456.78 == result.getLoyaltyBonusBurn());
		
		assertTrue(result.getItems().size() == 2);
		result.getItems().sort((ProductOrderItemFromOms item1, ProductOrderItemFromOms item2) -> {
			return Integer.compare(item1.getQuantity(), item2.getQuantity());
		});
		
		ProductOrderItemFromOms item1 = result.getItems().get(0);
		assertEquals("cde534", item1.getProductId());
		assertTrue(1 == item1.getQuantity());
		assertTrue(47.0 == item1.getPrice());
		assertTrue(45.0 == item1.getDiscount());
		
		ProductOrderItemFromOms item2 = result.getItems().get(1);
		assertEquals("abc123_45", item2.getProductId());
		assertTrue(12 == item2.getQuantity());
		assertTrue(1235.75 == item2.getPrice());
		assertTrue(123.45 == item2.getDiscount());
		
		assertTrue(result.getPersonalDiscounts().size() == 3);
		result.getPersonalDiscounts().sort((PersonalDiscountFromOms d1, PersonalDiscountFromOms d2) -> {
			return d1.getId().compareTo(d2.getId());
		});
		
		assertEquals("manual", result.getPersonalDiscounts().get(0).getCode());
		assertEquals("discountGuid1", result.getPersonalDiscounts().get(0).getId());
		assertEquals("regular", result.getPersonalDiscounts().get(1).getCode());
		assertEquals("discountGuid2", result.getPersonalDiscounts().get(1).getId());
		assertEquals("manual", result.getPersonalDiscounts().get(2).getCode());
		assertEquals("discountGuid3", result.getPersonalDiscounts().get(2).getId());
	}

	private SiteRootModel prepareData() {
		SiteRootModel source = new SiteRootModel();

		source.setOrderId("orderIdValue");
		source.setOrderGuid("orderGuidValue");
		source.setDateCreateIS("2017-07-19T13:00:34+3:00");
		source.setDeliveryCost(123.45);
		source.setShippingType("shippingTypeValue");
		source.setPaymentType("paymentTypeValue");
		source.setStoreHouse("storeHouseValue");
		source.setDiscountCard("discountCardValue");
		source.setStatusOrder("statusOrderValue");
		source.setDateOfPayment("2017-08-19");
		source.setSummaPayment(234.56);
		DeliveryAddressSite addressSite = new DeliveryAddressSite();
		addressSite.setCustomerGuid("customerGuid");
		addressSite.setLastName("lastName");
		addressSite.setFirstName("firstName");
		addressSite.setMobilePhone("mobilePhone");
		addressSite.setCity("city");
		addressSite.setCityId("cityId");
		addressSite.setStreet("street");
		addressSite.setHouse("house");
		addressSite.setBuilding("building");
		addressSite.setGate("gate");
		addressSite.setRoom("room");
		addressSite.setIndex("index");
		addressSite.setDeliveryComment("deliveryComment");
		source.setContactIS(addressSite);
		source.setBonusCalculated(345.67);
		source.setBonusClosed(456.78);

		List<ProductOrderItemFromSite> items = new ArrayList<ProductOrderItemFromSite>();
		ProductOrderItemFromSite item1 = new ProductOrderItemFromSite();
		item1.setProductId("abc123");
		item1.setSizeId("45");
		item1.setQuantity(12);
		item1.setPrice(123.45);
		item1.setPriceInitial(1235.75);
		items.add(item1);

		ProductOrderItemFromSite item2 = new ProductOrderItemFromSite();
		item2.setProductId("cde534");
		item2.setQuantity(1);
		item2.setPrice(45.0);
		item2.setPriceInitial(47.0);
		items.add(item2);
		source.setGoods(items);

		List<DiscountFromSite> manual = new ArrayList<DiscountFromSite>();
		List<DiscountFromSite> regular = new ArrayList<DiscountFromSite>();
		DiscountFromSite discount1 = new DiscountFromSite();
		discount1.setDiscountGuid("discountGuid1");
		DiscountFromSite discount2 = new DiscountFromSite();
		discount2.setDiscountGuid("discountGuid2");
		DiscountFromSite discount3 = new DiscountFromSite();
		discount3.setDiscountGuid("discountGuid3");
		manual.add(discount1);
		manual.add(discount3);
		regular.add(discount2);

		source.setManualDiscounts(manual);
		source.setDiscounts(regular);

		return source;
	}

}
