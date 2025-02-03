# Login into Meadow Cloud fails, error -4352

## Reported

Issue https://github.com/WildernessLabs/Meadow_Issues/issues/820

## Logging

```
 Meadow successfully started MONO
Initializing OS...
Parsing app.config.yaml...
[core] Log level: Trace
[core] Looking for app assembly...
[core] Found '/meadow0/App.dll'
[core] Looking for IApp...
[core] MeadowApp
 Mono is enabled
 Runtime disabled - restarting Meadow
 Mono is disabled
 Mono is disabled
 dev/
 little0 [block]
 little0p0 [block]
 monostderr [char]
 monostdout [char]
 mtdblock0 [block]
 null [char]
 nxupd [char]
 pipe0 [char]
 pwm0 [char]
 ramlog [char]
 random [char]
 ttyACM0 [char]
 ttyS0 [char]
 ttyS1 [char]
 ttyS2 [char]
 tun [char]
 upd [char]
 urandom [char]
 usrsock [char]
 meadow0/
 ./
 ../
 App.pdb [file]
 app.config.yaml [file]
 App.deps.json [file]
 meadow.config.yaml [file]
 Meadow.Contracts.dll [file]
 Meadow.F7.dll [file]
 Meadow.Logging.dll [file]
 Meadow.Units.dll [file]
 Microsoft.Extensions.Configuration.Abstractions.dll [file]
 Microsoft.Extensions.Configuration.dll [file]
 Microsoft.Extensions.Configuration.FileExtensions.dll [file]
 Microsoft.Extensions.FileProviders.Abstractions.dll [file]
 Microsoft.Extensions.FileProviders.Physical.dll [file]
 Microsoft.Extensions.FileSystemGlobbing.dll [file]
 Microsoft.Extensions.Primitives.dll [file]
 Mono.Security.dll [file]
 MQTTnet.dll [file]
 mscorlib.dll [file]
 mscorlib.pdb [file]
 NetEscapades.Configuration.Yaml.dll [file]
 netstandard.dll [file]
 System.Configuration.dll [file]
 System.Core.dll [file]
 System.Core.pdb [file]
 System.dll [file]
 System.IO.Compression.dll [file]
 System.IO.Compression.FileSystem.dll [file]
 System.Memory.dll [file]
 System.Net.Http.dll [file]
 System.Numerics.dll [file]
 System.pdb [file]
 System.Web.dll [file]
 System.Xml.dll [file]
 YamlDotNet.dll [file]
 Cache/
 ./
 ../
 Data/
 ./
 ../
 Documents/
 ./
 ../
 Temp/
 ./
 ../
 update-store/
 ./
 ../
 system/
 ./
 ../
 os_data.bin [file]
 App.dll [file]
 MicroJson.dll [file]
 System.IO.Hashing.dll [file]
 System.Security.dll [file]
 crash/
 ./
 ../
 meadow.error [file]
 Meadow.dll [file]
 Meadow.LogProviders.dll [file]
 meadow.log [file]
 dns.conf [file]
 var/
 mqueue/
 Esp32Events [char]
 Esp32Requests [char]
 IncomingEvents [char]
 File '/meadow0/meadow.log' deleted
 File '/meadow0/dns.conf' deleted
 Download of 'App.dll' succeeded (checksums calculated:0xC8B8AFF3, expected:0xC8B8AFF3)
 File 80% downloaded
 Download of 'App.pdb' succeeded (checksums calculated:0x2D10C2A5, expected:0x2D10C2A5)
 Mono is disabled
 Runtime enabled - restarting Meadow
 Meadow successfully started MONO
 Mono is enabled
 Mono is enabled
Initializing OS...
Parsing app.config.yaml...
 Meadow successfully started MONO
Initializing OS...
Parsing app.config.yaml...
[core] Log level: Trace
[core] Looking for app assembly...
[core] Found '/meadow0/App.dll'
[core] Looking for IApp...
[core] MeadowApp
[core] Creating 'F7CoreComputeV2' instance took 915ms
[core] Device Initialize starting...
[esp] Starting Esp32Coprocessor event handler thread.
[esp] Waiting for event.
[core] Device is configured to use WiFi for the network interface
[core] Device configured to auto-connect to SSID 'gspot'
[esp] Current state: Unknown
[esp] WiFi adapter state changed to: Connecting
[core] PlatformOS Initialize starting...
[esp] Event received.
[esp] Processing event.
[esp] Complex event, interface 1, event code: 47, message ID: 0x00000002
[esp] Getting event data for message ID 0x00000002
[esp] Event data collected, raising event.
[esp] Waiting for event.
[esp] Wifi InvokeEvent NetworkConnecting returned CompletedOk
[core] SD Card is configured to 'off'
[core] File system Initialize starting...
[core] Creating instance of MeadowApp...
[core] Creating 'MeadowApp' instance took 111ms
[core] Checking for Hardware property
[core] No Hardware property found in App.
[application] Health Metrics enabled with interval: 1 minute(s).
[core] Meadow cloud base features: enabled
[core] Meadow cloud updates: enabled
[core] Meadow cloud health metrics: enabled
[core] Initializing App
[application] Initialize...
[core] Running App
[application] Hello, Meadow Core-Compute!
[esp] Event received.
[esp] Processing event.
[esp] Simple event, interface 1, event code: 38, status code 0x00000000
[esp] Event data collected, raising event.
[esp] Waiting for event.
[esp] Event received.
[esp] Processing event.
[esp] Complex event, interface 1, event code: 36, message ID: 0x00000003
[esp] Getting event data for message ID 0x00000003
[esp] Event data collected, raising event.
[esp] Waiting for event.
[esp] Wifi InvokeEvent NtpUpdateEvent returned CompletedOk
[esp] Wifi InvokeEvent NetworkConnectedEvent returned CompletedOk
[esp] WiFi adapter state changed to: Connected
[application] Interface: wlan0: wlan0 Wireless80211 Up
[application] starting health metrics timer
[application] Meadow.Cloud service will use the Esp32WiFiAdapter network interface
[cloud] Attempting to login to https://www.meadowcloud.co/api/devices/login with {"id":"38-00-2F-00-0D-50-4B-55-30-38-31-20"}...
failed to parse private key -4352
[application] Failed to authenticate with Meadow.Cloud
[cloud] Attempting to login to https://www.meadowcloud.co/api/devices/login with {"id":"38-00-2F-00-0D-50-4B-55-30-38-31-20"}...
[application] Failed to authenticate with Meadow.Cloud
```