/**
 * IWebserviceSkeleton.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis2 version: 1.7.3  Built on : May 30, 2016 (04:08:57 BST)
 */
package webservice.skeleton;

/**
 *  IWebserviceSkeleton java skeleton for the axisService
 */
public class IWebserviceSkeleton implements IWebserviceSkeletonInterface {
    /**
     * Auto generated method signature
     *
     * @param testing0
     * @return testingResponse1
     */
    public webservice.TestingResponse testing(webservice.Testing testing0) {
    	webservice.TestingResponse res = new webservice.TestingResponse();
        
    	res.set_return("web service working!");
    	return res;
    }
}
