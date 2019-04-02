package com.starfish.muleesb.domain.productupdate;

import static org.junit.Assert.*;

import java.io.File;
import java.io.IOException;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Unmarshaller;

import org.junit.Test;


public class ProductMappingTest {

	@Test
	public void test() throws IOException, JAXBException {
		File file = new File(getClass().getResource("/Message_MOS_TMZ_0000000019.xml").getFile());
        JAXBContext context = JAXBContext.newInstance(Product.class, SimpleColor.class, SizeClassifier.class, AssortmentType.class,
        		ProductGroup.class, ProductType.class, HeelType.class, Season.class, Collection.class, ClassifierOfCountry.class,
        		Trademark.class, SimpleMaterial.class, Currency.class, Language.class, RetailClient.class, ProductDesign.class,
        		DiscountCard.class, Region.class, City.class, Salon.class, BoxLine.class, ProductBox.class,
        		ProductFile.class, Message.class, Header.class, Body.class);
        Unmarshaller unmarshaller = context.createUnmarshaller();
        Message message = (Message) unmarshaller.unmarshal(file);
        assertNotNull(message);
        assertNotNull(message.getBody());
        assertNotNull(message.getBody().getSimpleColors());
        assertNotNull(message.getBody().getSimpleColors().get(0));
        
	}

}
