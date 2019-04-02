package com.starfish.muleesb.transformers;

import java.io.ByteArrayInputStream;
import java.io.IOException;
import java.io.InputStream;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Unmarshaller;

import org.mule.api.transformer.TransformerException;
import org.mule.transformer.AbstractTransformer;
import org.springframework.beans.factory.annotation.Autowired;

import com.starfish.muleesb.jaxb.factory.JaxbContextProvider;

public class CustomXmlToJaxbObjectTransformer extends AbstractTransformer {

	private JaxbContextProvider provider;

	private String beanName;

	@Override
	protected Object doTransform(Object src, String enc) throws TransformerException {
		JAXBContext jaxbContext = provider.getContext(beanName);
		InputStream is = null;
		try {
			String input = (String) src;
			is = new ByteArrayInputStream(input.getBytes());
			Unmarshaller unmarshaller = jaxbContext.createUnmarshaller();
			Object result = unmarshaller.unmarshal(is);
			return result;
		} catch (JAXBException e) {
			throw new TransformerException(this, e);
		} finally {
			if (is != null) {
				try {
					is.close();
				} catch (IOException e) {
					e.printStackTrace();
				}
			}
		}
	}

	public String getBeanName() {
		return beanName;
	}

	public void setBeanName(String beanName) {
		this.beanName = beanName;
	}

	@Autowired
	public void setProvider(JaxbContextProvider provider) {
		this.provider = provider;
	}
}
