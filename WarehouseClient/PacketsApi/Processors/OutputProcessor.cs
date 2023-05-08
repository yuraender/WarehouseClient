using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using WarehouseClient.PacketsApi.Packets;

namespace WarehouseClient.PacketsApi.Processors {
    public class OutputProccessor {

        private Thread _thread;
        private readonly BinaryWriter _writer;
        private readonly Queue<PacketBase> _packets;
        private readonly ManualResetEvent _lock;

        public OutputProccessor(NetworkStream stream) {
            _writer = new BinaryWriter(stream);
            _packets = new Queue<PacketBase>();
            _lock = new ManualResetEvent(true);
        }

        public void Send(PacketBase packet) {
            _packets.Enqueue(packet);
            _lock.Set();
        }

        public void Run() {
            _thread = new Thread(() => {
                try {
                    while (true) {
                        _lock.WaitOne();
                        if (_packets.Count > 0) {
                            _packets.Dequeue().Write(_writer);
                        } else {
                            _lock.Reset();
                        }
                    }
                } catch (Exception ex) {
                    //MessageBox.Show(ex.ToString());
                    Process.GetCurrentProcess().Kill();
                }
            });
            _thread.Start();
        }

        public void Stop() {
            _writer.Close();
            _thread.Interrupt();
            _thread.Abort();
        }
    }
}
