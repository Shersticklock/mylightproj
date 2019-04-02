package com.starfish.muleesb.services.combiners;

import java.util.ArrayList;
import java.util.List;

import com.starfish.muleesb.domain.productupdate.Group;
import com.starfish.muleesb.domain.productupdate.Product;

public class ProductListCombiner {

	public List<Product> combine(List<Group> groups) {
		List<Product> products = new ArrayList<Product>();
		for (Group group : groups) {
			for (Product product : group.getProducts()) {
				products.add(product);
			}
		}
		return products;
	}
	
}
