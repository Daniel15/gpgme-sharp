﻿/*
 * libgpgme-sharp - .NET wrapper classes for libgpgme (GnuPG Made Easy)
 *  Copyright (C) 2008 Daniel Mueller <daniel@danm.de>
 *
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Libgpgme.Interop
{
    [StructLayout(LayoutKind.Sequential)]
    internal class _gpgme_op_genkey_result
    {
        uint flags;
        public IntPtr fpr;

        /* A primary key was generated.  */
        public bool primary {
            get { return ((flags & 1) > 0); }
            set
            {
                if (value)
                    flags |= 1;
                else
                    flags &= (~(uint)1);
            }
        }
        /* A sub key was generated.  */
        public bool sub {
            get { return ((flags & 2) > 0); }
            set
            {
                if (value)
                    flags |= 2;
                else
                    flags &= (~(uint)2);
            }
        }
    }
}
