package com.starfish.muleesb.services.converters;

import java.util.ArrayList;
import java.util.List;

import com.starfish.muleesb.domain.productupdate.ProductJson;

public class ProductListSplitter {
	
	private static final int MAX_PRODUCT_PACKAGE_SIZE = 1000;

	public List<List<ProductJson>> split(List<ProductJson> list) {
		List<List<ProductJson>> productPackages = new ArrayList<List<ProductJson>>();
		
		productPackages.add(new ArrayList<ProductJson>());
		int index = 0;
		
		for (ProductJson product : list) {
			if (productPackages.get(index).size() >= MAX_PRODUCT_PACKAGE_SIZE) {
				productPackages.add(new ArrayList<ProductJson>());
				index++;
			}
			productPackages.get(index).add(product);
		}
		
		return productPackages;
	}

}
