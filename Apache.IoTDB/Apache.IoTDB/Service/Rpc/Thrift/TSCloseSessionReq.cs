/**
 * Autogenerated by Thrift Compiler (0.13.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


namespace Apache.IoTDB.Service.Rpc.Thrift
{

  public partial class TSCloseSessionReq : TBase
  {

    public long SessionId { get; set; }

    public TSCloseSessionReq()
    {
    }

    public TSCloseSessionReq(long sessionId) : this()
    {
      this.SessionId = sessionId;
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_sessionId = false;
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.I64)
              {
                SessionId = await iprot.ReadI64Async(cancellationToken);
                isset_sessionId = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
        if (!isset_sessionId)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var struc = new TStruct("TSCloseSessionReq");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        field.Name = "sessionId";
        field.Type = TType.I64;
        field.ID = 1;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI64Async(SessionId, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      var other = that as TSCloseSessionReq;
      if (other == null) return false;
      if (ReferenceEquals(this, other)) return true;
      return System.Object.Equals(SessionId, other.SessionId);
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        hashcode = (hashcode * 397) + SessionId.GetHashCode();
      }
      return hashcode;
    }

    public override string ToString()
    {
      var sb = new StringBuilder("TSCloseSessionReq(");
      sb.Append(", SessionId: ");
      sb.Append(SessionId);
      sb.Append(")");
      return sb.ToString();
    }
  }

}
