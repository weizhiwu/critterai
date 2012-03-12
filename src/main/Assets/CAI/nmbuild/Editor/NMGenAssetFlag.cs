﻿/*
 * Copyright (c) 2012 Stephen A. Pratt
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */
using org.critterai.nmgen;

namespace org.critterai.nmbuild
{
    /// <summary>
    /// Asset types created during the NMGen build process.
    /// </summary>
    [System.Flags]
    public enum NMGenAssetFlag
    {
        /// <summary>
        /// The <see cref="Heightfield"/> intermediate asset.
        /// </summary>
        Heightfield  = 0x01,

        /// <summary>
        /// The <see cref="CompactHeightfield"/> intermediate asset.
        /// </summary>
        CompactField = 0x02,

        /// <summary>
        /// The <see cref="ContourSet"/> intermediate asset.
        /// </summary>
        ContourSet   = 0x04,

        /// <summary>
        /// The <see cref="PolyMesh"/> final asset.
        /// </summary>
        PolyMesh     = 0x08,

        /// <summary>
        /// The <see cref="PolyMeshDetail"/> final asset.
        /// </summary>
        DetailMesh   = 0x10
    }
}
