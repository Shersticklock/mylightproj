package com.starfish.muleesb.domain.shippingupdates.sdek.request;

import static org.junit.Assert.*;

import java.io.File;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Unmarshaller;

import org.junit.Test;

public class SdekRequestDataTest {

	@Test
	public void testRequestParsing1() throws JAXBException {
		File file = new File(getClass().getResource("/sdek/sdek-request-1.xml").getFile());
		JAXBContext context = JAXBContext.newInstance(ChangePeriod.class, Order.class, SdekRequestData.class);
		Unmarshaller unmarshaller = context.createUnmarshaller();
		SdekRequestData result = (SdekRequestData) unmarshaller.unmarshal(file);
		
		assertNotNull(result);
		assertEquals(result.getDate(), "2013-07-17");
		assertEquals(result.getAccount(), "123");
		assertEquals(result.getSecure(), "123");
		assertTrue(result.getShowHistory() == 1);
		assertNull(result.getShowReturnOrder());
		assertNull(result.getShowReturnOrderHistory());
		
		assertNotNull(result.getChangePeriod());
		assertEquals(result.getChangePeriod().getDateFirst(), "2013-07-16");
		assertEquals(result.getChangePeriod().getDateLast(), "2013-07-17");
		
		assertNull(result.getOrders());
	}
	
	@Test
	public void testRequestParsing2() throws JAXBException {
		File file = new File(getClass().getResource("/sdek/sdek-request-2.xml").getFile());
		JAXBContext context = JAXBContext.newInstance(ChangePeriod.class, Order.class, SdekRequestData.class);
		Unmarshaller unmarshaller = context.createUnmarshaller();
		SdekRequestData result = (SdekRequestData) unmarshaller.unmarshal(file);
		
		assertNotNull(result);
		assertEquals(result.getDate(), "2013-07-17");
		assertEquals(result.getAccount(), "123");
		assertEquals(result.getSecure(), "123");
		assertTrue(result.getShowHistory() == 1);
		assertNull(result.getShowReturnOrder());
		assertNull(result.getShowReturnOrderHistory());
		
		assertNotNull(result.getChangePeriod());
		assertEquals(result.getChangePeriod().getDateFirst(), "2013-07-16");
		assertEquals(result.getChangePeriod().getDateLast(), "2013-07-17");

		assertNotNull(result.getOrders());
		assertTrue(result.getOrders().size() == 2);
		result.getOrders().sort((Order arg1, Order arg2) -> {
			return Integer.compare(
					Integer.valueOf(arg1.getNumber()),
					Integer.valueOf(arg2.getNumber()));
		});
		Order order1 = result.getOrders().get(0);
		assertEquals(order1.getNumber(), "6346860");
		assertEquals(order1.getDate(), "2013-07-04");
		assertNull(order1.getDispatchNumber());

		Order order2 = result.getOrders().get(1);
		assertEquals(order2.getNumber(), "6346869");
		assertEquals(order2.getDate(), "2013-07-16");
		assertNull(order2.getDispatchNumber());
	}

}
