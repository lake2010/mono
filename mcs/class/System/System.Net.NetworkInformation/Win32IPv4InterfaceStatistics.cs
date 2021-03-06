//
// System.Net.NetworkInformation.IPv4InterfaceStatistics
//
// Authors:
//	Gonzalo Paniagua Javier (gonzalo@novell.com)
//	Atsushi Enomoto (atsushi@ximian.com)
//	Miguel de Icaza (miguel@ximian.com)
//
// Copyright (c) 2006-2008 Novell, Inc. (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
#if WIN_PLATFORM
namespace System.Net.NetworkInformation {
	class Win32IPv4InterfaceStatistics : IPv4InterfaceStatistics
	{
		Win32_MIB_IFROW info;

		public Win32IPv4InterfaceStatistics (Win32_MIB_IFROW info)
		{
			this.info = info;
		}

		public override long BytesReceived {
			get { return info.InOctets; }
		}

		public override long BytesSent {
			get { return info.OutOctets; }
		}

		public override long IncomingPacketsDiscarded {
			get { return info.InDiscards; }
		}

		public override long IncomingPacketsWithErrors {
			get { return info.InErrors; }
		}

		public override long IncomingUnknownProtocolPackets {
			get { return info.InUnknownProtos; }
		}

		public override long NonUnicastPacketsReceived {
			get { return info.InNUcastPkts; }
		}

		public override long NonUnicastPacketsSent {
			get { return info.OutNUcastPkts; }
		}

		public override long OutgoingPacketsDiscarded {
			get { return info.OutDiscards; }
		}

		public override long OutgoingPacketsWithErrors {
			get { return info.OutErrors; }
		}

		public override long OutputQueueLength {
			get { return info.OutQLen; }
		}

		public override long UnicastPacketsReceived {
			get { return info.InUcastPkts; }
		}

		public override long UnicastPacketsSent {
			get { return info.OutUcastPkts; }
		}

	}
}
#endif
