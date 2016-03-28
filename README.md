UC.NET
------

A generalized UC client.

Usage
-----

The UcClient library can be used with any of the versioned client libraries such as Axl, Sxml, or even with the non-soap APIs such as webex's XML based REST API.  Just reference UcClient along with a generated api client similar to the unit tests.

Example
-------

```c#
    public bool SipTrunktoCupExists()
    {
        var risClient = new RisClient(new UcClientSettings { Server = "10.10.20.1", User = "administrator", Password = "ciscopsdt" });

        var result = risClient.Execute(client =>
        {
            var criteria = new CmSelectionCriteria()
            {
                MaxReturnedDevices = 1000,
                DeviceClass = "Any",
                Model = 255, //refers to any device, full listing here: https://developer.cisco.com/site/sxml/documents/api-reference/risport/#ModelTable
                Status = "Any",
                NodeName = string.Empty, //null for all nodes
                SelectBy = CmSelectBy.Name,
                SelectItems = new ArrayOfSelectItem() { new SelectItem() { Item = "SIPTrunktoCUP" } },
                //SelectItems = new ArrayOfSelectItem(),  //blank for everything
                Protocol = ProtocolType.Any,
                DownloadStatus = DeviceDownloadStatus.Any,
            };

            var res = client.selectCmDevice(string.Empty, criteria);

            return res;
        });

        if (result.Exception != null)
            throw result.Exception;

        Return result.Value.SelectCmDeviceResult.TotalDevicesFound == 1;
    }