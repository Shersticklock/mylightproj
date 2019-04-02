package com.starfish.muleesb.services.converters;

import java.lang.reflect.Field;
import java.util.ArrayList;
import java.util.List;

import com.starfish.muleesb.domain.productupdate.Body;
import com.starfish.muleesb.domain.productupdate.Message;
import com.starfish.muleesb.domain.productupdate.ProductDictionary;
import com.starfish.muleesb.stereotype.IsProductDictionary;

public class MessageToDictionaryConverter {

	public List<ProductDictionary> convert(Message message) throws IllegalArgumentException, IllegalAccessException, NoSuchFieldException, SecurityException {
		List<ProductDictionary> productDictionaries = new ArrayList<ProductDictionary>();
		
		Class<? extends Body> bodyClass = message.getBody().getClass();
		Field[] bodyFields = bodyClass.getDeclaredFields();
		for (Field bodyField : bodyFields) {
			if (!"java.util.List".equals(bodyField.getType().getName())) {
				continue;
			}
			
			bodyField.setAccessible(true);
			@SuppressWarnings("rawtypes")
			List list = (List) bodyField.get(message.getBody());
			if (list == null || list.size() <= 0) {
				continue;
			}
			
			Object firstElement = list.get(0);
			if (firstElement.getClass().getAnnotation(IsProductDictionary.class) == null) {
				continue;
			}
			
			for (Object item : list) {
				Field guidField = item.getClass().getDeclaredField("guid");
				guidField.setAccessible(true);
				String guid = (String) guidField.get(item);
				Field[] itemFields = item.getClass().getDeclaredFields();
				for (Field propertyField : itemFields) {
					if ("guid".equals(propertyField.getName())) {
						continue;
					}
					ProductDictionary productDictionary = new ProductDictionary();
					productDictionary.setGuid(guid);
					productDictionary.setType(bodyField.getName());
					productDictionary.setName(propertyField.getName());
					propertyField.setAccessible(true);
					productDictionary.setValue(propertyField.get(item).toString());
					productDictionaries.add(productDictionary);
				}
			}
		}
		return productDictionaries;
	}
	
}
