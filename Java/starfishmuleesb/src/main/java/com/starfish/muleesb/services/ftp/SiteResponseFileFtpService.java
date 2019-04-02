package com.starfish.muleesb.services.ftp;

import java.io.IOException;
import java.io.InputStream;
import java.net.SocketException;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Map.Entry;
import java.util.Set;

import org.apache.commons.io.IOUtils;
import org.apache.commons.net.ftp.FTPClient;
import org.apache.commons.net.ftp.FTPFile;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.stereotype.Component;

@Component
public class SiteResponseFileFtpService {

	@Value("${site.ftp.product.update.host}")
	private String host;

	@Value("${site.ftp.product.update.port}")
	private int port;

	@Value("${site.ftp.product.update.path}")
	private String path;

	@Value("${site.ftp.product.update.username}")
	private String username;

	@Value("${site.ftp.product.update.password}")
	private String password;

	@Value("${starfish.api.product.update.timeout:172800000}")
	private long timeout;
	
	@Value("${ftp.product.update.outboundpattern}")
	private String filePattern;

	public Set<Entry<String, String>> receiveFile(long startTime) throws Exception {
		while (true) {
			long currentTime = System.currentTimeMillis();
			if (currentTime >= (startTime + timeout)) {
				throw new Exception("Time for waiting is over!");
			}

			FTPClient client = null;
			try {
				client = new FTPClient();
				client.connect(host, port);
				client.login(username, password);
				FTPFile[] files = client.listFiles(path);
				List<FTPFile> actualFiles = getActualFilesFromArray(files);

				if (actualFiles.isEmpty()) {
					Thread.sleep(60000L);
					continue;
				}

				Map<String, String> result = new HashMap<String, String>();
				for (FTPFile file : actualFiles) {
					String filepath = composeFilepath(file.getName());
					String content = readContent(filepath, client);
					result.put(file.getName(), content);
				}
				return result.entrySet();
			} catch (InterruptedException | IOException e) {
				e.printStackTrace();
			} finally {
				if (client != null) {
					client.disconnect();
				}
			}
		}
	}
	
	public void deleteFile(String filename) throws SocketException, IOException {
		FTPClient client = null;
		try {
			client = new FTPClient();
			client.connect(host, port);
			client.login(username, password);
			String filepath = composeFilepath(filename);
			client.deleteFile(filepath);
		} finally {
			if (client != null) {
				client.disconnect();
			}
		}
	}

	private String composeFilepath(String filename) {
		Path result = Paths.get(path, filename);
		return result.toString();
	}

	private String readContent(String filepath, FTPClient client) throws IOException {
		InputStream is = null;
		String result = null;
		try {
			is = client.retrieveFileStream(filepath);
			result = IOUtils.toString(is);
			client.completePendingCommand();
		} finally {
			if (is != null) {
				IOUtils.closeQuietly(is);
			}
		}
		return result;
	}

	private List<FTPFile> getActualFilesFromArray(FTPFile[] files) {
		List<FTPFile> actualFiles = new ArrayList<FTPFile>();
		for (FTPFile file : files) {
			if (file.getName().toLowerCase().startsWith(filePattern)
					&& file.getName().toLowerCase().endsWith(".xml") && file.isFile()) {
				actualFiles.add(file);
			}
		}
		return actualFiles;
	}

}
