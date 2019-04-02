package com.starfish.muleesb.domain.ordertooms.sitemodels;

import static org.junit.Assert.*;

import java.io.IOException;

import org.codehaus.jackson.map.ObjectMapper;
import org.junit.Test;

public class SiteRootModelTest {

	@Test
	public void test() throws IOException {
		String sourceJson = "{\"OrderID\":\"123456\",\"DateCreateIS\":\"2018-01-01T12:00:05+3:00\",\"DeliveryCost\":500,"
				+ "\"GUID_ShippingType\":\"488435e3-c56e-11e3-9894-00150000002f\","
				+ "\"GUID_PaymentType\":\"992be0b1-d4c5-11e2-886d-003048631e6f\","
				+ "\"GUID_StoreHouse\":\"6c2531a6-3a27-11e7-80be-005056b12d66\","
				+ "\"GUID_DiscontCard\":\"488435e3-c56e-11e3-9894-00150000002f\","
				+ "\"GUID_StatusOrder\":\"112531a6-3a27-11e7-80be-005056b12d66\","
				+ "\"DatePayment\":\"2018-02-08\",\"SummaPayment\":19000,"
				+ "\"ContactIS\":{\"GUID_Customer\":\"6c2531a6-3a27-11e7-80be-005056b12d66\","
				+ "\"LastName\":\"Иванов\",\"FirstName\":\"Иван\",\"MobilePhone\":\"79262775799\","
				+ "\"City\":\"Санкт-Петербург\",\"CityId\":\"77\",\"Street\":\"Садовая\",\"House\":\"15\","
				+ "\"Building\":\"Лит А\",\"Gate\":\"2\",\"Room\":\"35\",\"Index\":\"737245\","
				+ "\"DeliveryComment\":\"Позвоните в домофон\"},\"BonusCalculated\":230,\"BonusClosed\":300,"
				+ "\"Goods\":[{\"IdProduct\":\"123321\",\"IdSize\":\"43\",\"Quantity\":1,\"PriceInitial\":5099.99,\"Price\":3099},"
				+ "{\"IdProduct\":\"325557\",\"IdSize\":\"42\",\"Quantity\":1,\"PriceInitial\":7099.99,\"Price\":4099.9}],"
				+ "\"ManualDiscounts\":[{\"GUID_Discount\":\"488435e3-c56e-11e3-9894-001500000001\"},"
				+ "{\"GUID_Discount\":\"сс3435e3-c56e-11e3-9894-001500000002\"}],"
				+ "\"Discounts\":[{\"GUID_Discount\":\"488435e3-c56e-11e3-9894-001500000003\"},"
				+ "{\"GUID_Discount\":\"сс3435e3-c56e-11e3-9894-001500000004\"}]}";
		
		ObjectMapper mapper = new ObjectMapper();
		SiteRootModel result = mapper.readValue(sourceJson, SiteRootModel.class);
		
		assertTrue("123456".equals(result.getOrderId()));
		assertTrue("2018-01-01T12:00:05+3:00".equals(result.getDateCreateIS()));
		assertTrue(result.getDeliveryCost() == 500.0);
		assertTrue(result.getShippingType().equals("488435e3-c56e-11e3-9894-00150000002f"));
		assertTrue(result.getPaymentType().equals("992be0b1-d4c5-11e2-886d-003048631e6f"));
		assertTrue(result.getStoreHouse().equals("6c2531a6-3a27-11e7-80be-005056b12d66"));
		assertTrue(result.getDiscountCard().equals("488435e3-c56e-11e3-9894-00150000002f"));
		assertTrue(result.getStatusOrder().equals("112531a6-3a27-11e7-80be-005056b12d66"));
		assertTrue(result.getDateOfPayment().equals("2018-02-08"));
		assertTrue(result.getSummaPayment() == 19000);
		assertTrue(result.getBonusCalculated() == 230);
		assertTrue(result.getBonusClosed() == 300);
		
		DeliveryAddressSite address = result.getContactIS();
		assertTrue(address.getCustomerGuid().equals("6c2531a6-3a27-11e7-80be-005056b12d66"));
		assertTrue(address.getLastName().equals("Иванов"));
		assertTrue(address.getFirstName().equals("Иван"));
		assertTrue(address.getMobilePhone().equals("79262775799"));
		assertTrue(address.getCity().equals("Санкт-Петербург"));
		assertTrue(address.getCityId().equals("77"));
		assertTrue(address.getStreet().equals("Садовая"));
		assertTrue(address.getHouse().equals("15"));
		assertTrue(address.getBuilding().equals("Лит А"));
		assertTrue(address.getGate().equals("2"));
		assertTrue(address.getRoom().equals("35"));
		assertTrue(address.getIndex().equals("737245"));
		assertTrue(address.getDeliveryComment().equals("Позвоните в домофон"));
		
		assertTrue(result.getGoods() != null);
		assertTrue(result.getGoods().size() == 2);
		
		assertTrue(result.getManualDiscounts() != null);
		assertTrue(result.getManualDiscounts().size() == 2);
		
		assertTrue(result.getDiscounts() != null);
		assertTrue(result.getDiscounts().size() == 2);
	}

}
